## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20240305-035446
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25FB140ADC0
+       mov       r8,2603A408DC8
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
-       call      qword ptr [7FFF82D17888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D27630]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,25FB140ADB8
+       mov       rdx,2603A408DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824E4210]
-       mov       rcx,25FB140ADC0
+       call      qword ptr [7FFF824F4210]
+       mov       rcx,2603A408DC8
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
-       mov       r15,[rax+38]
-       test      r15,r15
-       mov       rax,[rbp-38]
+       mov       r14,[rax+38]
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
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F59080
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       r15,[rax+38]
-       test      r15,r15
-       mov       rax,[rbp-38]
+       mov       r14,[rax+38]
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
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F59080
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823A0D50
+       mov       r11,7FFF823B0D50
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F482B8
+       mov       rdx,7FFF82F58FA8
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
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-30]
+       mov       r11,7FFF823B0D58
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
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF823B0D58
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
-; Total bytes of code 603
+; Total bytes of code 604
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25FB140ADC0
+       mov       r8,26E31C0ADC0
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
-       call      qword ptr [7FFF82D17888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D27888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,25FB140ADB8
+       mov       rdx,26E31C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824E4210]
-       mov       rcx,25FB140ADC0
+       call      qword ptr [7FFF824F4210]
+       mov       rcx,26E31C0ADC0
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
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F59280
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F59280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823A0D50
+       mov       r11,7FFF823B0D50
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F482B8
+       mov       rdx,7FFF82F591A8
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
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF823B0D58
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
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823B0D58
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
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25FB140ADC0
+       mov       r8,28317C08DC8
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
-       call      qword ptr [7FFF82D17888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D16910]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,25FB140ADB8
+       mov       rdx,28317C08DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824E4210]
-       mov       rcx,25FB140ADC0
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,28317C08DC8
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
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F51AF0
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F51AF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823A0D50
+       mov       r11,7FFF82390E38
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F482B8
+       mov       rdx,7FFF82F51A18
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
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF82390E40
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
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82390E40
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
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25FB140ADC0
+       mov       r8,17F90C0ADC0
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
-       call      qword ptr [7FFF82D17888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D8CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,25FB140ADB8
+       mov       rdx,17F90C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824E4210]
-       mov       rcx,25FB140ADC0
+       mov       r8,7FFF82E83AC8
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,17F90C0ADC0
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F4C638
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F4C638
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823A0D50
+       mov       r11,7FFF82391038
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F482B8
+       mov       rdx,7FFF82F4C560
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
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391040
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
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391040
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
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25FB140ADC0
+       mov       r8,1AA5040ADC0
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
-       call      qword ptr [7FFF82D17888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0E748]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,25FB140ADB8
+       mov       rdx,1AA5040ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824E4210]
-       mov       rcx,25FB140ADC0
+       mov       r8,7FFF82E89F08
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,1AA5040ADC0
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F60AD8
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F60AD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823A0D50
+       mov       r11,7FFF823912B8
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F482B8
+       mov       rdx,7FFF82F60A00
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
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823912C0
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
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF823912C0
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25FB140ADC0
+       mov       r8,205EA40ADC0
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
-       call      qword ptr [7FFF82D17888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E2D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,25FB140ADB8
+       mov       rdx,205EA40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824E4210]
-       mov       rcx,25FB140ADC0
+       mov       r8,7FFF82EA86A8
+       call      qword ptr [7FFF824F4210]
+       mov       rcx,205EA40ADC0
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F6F980
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F6F980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823A0D50
+       mov       r11,7FFF823B1300
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F482B8
+       mov       rdx,7FFF82F6F8A8
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
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823B1308
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
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF823B1308
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25FB140ADC0
+       mov       r8,189F8C0ADC0
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
-       call      qword ptr [7FFF82D17888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0DDE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,25FB140ADB8
+       mov       rdx,189F8C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824E4210]
-       mov       rcx,25FB140ADC0
+       mov       r8,7FFF82E88D20
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,189F8C0ADC0
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F4F830
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F48390
+       mov       rdx,7FFF82F4F830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823A0D50
+       mov       r11,7FFF82391340
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
-       call      qword ptr [7FFF82D96FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F482B8
+       mov       rdx,7FFF82F4F758
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
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82744F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
-       mov       r11,7FFF823A0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2603A408DC8
+       mov       r8,26E31C0ADC0
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
-       call      qword ptr [7FFF82D27630]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D27888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2603A408DC0
+       mov       rdx,26E31C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FFF824F4210]
-       mov       rcx,2603A408DC8
+       mov       rcx,26E31C0ADC0
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
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F59280
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F59280
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FFF823B0D50
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F58FA8
+       mov       rdx,7FFF82F591A8
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
        mov       r11,7FFF823B0D58
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
        mov       r11,7FFF823B0D58
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
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2603A408DC8
+       mov       r8,28317C08DC8
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
-       call      qword ptr [7FFF82D27630]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D16910]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2603A408DC0
+       mov       rdx,28317C08DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,2603A408DC8
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,28317C08DC8
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
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F51AF0
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F51AF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82390E38
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F58FA8
+       mov       rdx,7FFF82F51A18
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF823B0D58
+       mov       rcx,rax
+       mov       r11,7FFF82390E40
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
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82390E40
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
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2603A408DC8
+       mov       r8,17F90C0ADC0
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
-       call      qword ptr [7FFF82D27630]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D8CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2603A408DC0
+       mov       rdx,17F90C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,2603A408DC8
+       mov       r8,7FFF82E83AC8
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,17F90C0ADC0
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F4C638
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F4C638
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82391038
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F58FA8
+       mov       rdx,7FFF82F4C560
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391040
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
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391040
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
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2603A408DC8
+       mov       r8,1AA5040ADC0
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
-       call      qword ptr [7FFF82D27630]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0E748]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2603A408DC0
+       mov       rdx,1AA5040ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,2603A408DC8
+       mov       r8,7FFF82E89F08
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,1AA5040ADC0
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F60AD8
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F60AD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF823912B8
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F58FA8
+       mov       rdx,7FFF82F60A00
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823912C0
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
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823912C0
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2603A408DC8
+       mov       r8,205EA40ADC0
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
-       call      qword ptr [7FFF82D27630]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E2D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2603A408DC0
+       mov       rdx,205EA40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFF82EA86A8
        call      qword ptr [7FFF824F4210]
-       mov       rcx,2603A408DC8
+       mov       rcx,205EA40ADC0
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F6F980
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F6F980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF823B1300
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F58FA8
+       mov       rdx,7FFF82F6F8A8
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
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823B1308
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
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823B1308
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2603A408DC8
+       mov       r8,189F8C0ADC0
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
-       call      qword ptr [7FFF82D27630]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0DDE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2603A408DC0
+       mov       rdx,189F8C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,2603A408DC8
+       mov       r8,7FFF82E88D20
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,189F8C0ADC0
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F4F830
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
-       mov       r14,[rax+38]
-       test      r14,r14
-       mov       rax,[rbp-30]
+       mov       r15,[rax+38]
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
-       mov       rdx,7FFF82F59080
+       mov       rdx,7FFF82F4F830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82391340
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
-       call      qword ptr [7FFF82DA6FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F58FA8
+       mov       rdx,7FFF82F4F758
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-30]
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,26E31C0ADC0
+       mov       r8,28317C08DC8
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
-       call      qword ptr [7FFF82D27888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D16910]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,26E31C0ADB8
+       mov       rdx,28317C08DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,26E31C0ADC0
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,28317C08DC8
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
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F51AF0
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        je        near ptr M01_L18
        jmp       near ptr M01_L01
        mov       rcx,[rbp-38]
        call      qword ptr [r11]
        mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F51AF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82390E38
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F591A8
+       mov       rdx,7FFF82F51A18
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,rax
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF82390E40
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
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF82390E40
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,26E31C0ADC0
+       mov       r8,17F90C0ADC0
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
-       call      qword ptr [7FFF82D27888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D8CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,26E31C0ADB8
+       mov       rdx,17F90C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,26E31C0ADC0
+       mov       r8,7FFF82E83AC8
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,17F90C0ADC0
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F4C638
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F4C638
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82391038
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F591A8
+       mov       rdx,7FFF82F4C560
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391040
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
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF82391040
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
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,26E31C0ADC0
+       mov       r8,1AA5040ADC0
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
-       call      qword ptr [7FFF82D27888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0E748]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,26E31C0ADB8
+       mov       rdx,1AA5040ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,26E31C0ADC0
+       mov       r8,7FFF82E89F08
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,1AA5040ADC0
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F60AD8
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F60AD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF823912B8
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F591A8
+       mov       rdx,7FFF82F60A00
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823912C0
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
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823912C0
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,26E31C0ADC0
+       mov       r8,205EA40ADC0
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
-       call      qword ptr [7FFF82D27888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E2D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,26E31C0ADB8
+       mov       rdx,205EA40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFF82EA86A8
        call      qword ptr [7FFF824F4210]
-       mov       rcx,26E31C0ADC0
+       mov       rcx,205EA40ADC0
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F6F980
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F6F980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF823B1300
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F591A8
+       mov       rdx,7FFF82F6F8A8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823B1308
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
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823B1308
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,26E31C0ADC0
+       mov       r8,189F8C0ADC0
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
-       call      qword ptr [7FFF82D27888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0DDE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,26E31C0ADB8
+       mov       rdx,189F8C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,26E31C0ADC0
+       mov       r8,7FFF82E88D20
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,189F8C0ADC0
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F4F830
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F59280
+       mov       rdx,7FFF82F4F830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B0D50
+       mov       r11,7FFF82391340
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
-       call      qword ptr [7FFF82DA6D90]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F591A8
+       mov       rdx,7FFF82F4F758
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF823B0D58
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF82391348
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
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,28317C08DC8
+       mov       r8,17F90C0ADC0
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
-       call      qword ptr [7FFF82D16910]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82D8CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,28317C08DC0
+       mov       rdx,17F90C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFF82E83AC8
        call      qword ptr [7FFF824D4210]
-       mov       rcx,28317C08DC8
+       mov       rcx,17F90C0ADC0
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F4C638
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E83AC8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F4C638
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF82390E38
+       mov       r11,7FFF82391038
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51A18
+       mov       rdx,7FFF82F4C560
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF82390E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391040
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
-       mov       r11,7FFF82390E40
+       mov       r11,7FFF82391040
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
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,28317C08DC8
+       mov       r8,1AA5040ADC0
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
-       call      qword ptr [7FFF82D16910]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0E748]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,28317C08DC0
+       mov       rdx,1AA5040ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFF82E89F08
        call      qword ptr [7FFF824D4210]
-       mov       rcx,28317C08DC8
+       mov       rcx,1AA5040ADC0
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F60AD8
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F60AD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF82390E38
+       mov       r11,7FFF823912B8
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51A18
+       mov       rdx,7FFF82F60A00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF82390E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823912C0
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
-       mov       r11,7FFF82390E40
+       mov       r11,7FFF823912C0
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,28317C08DC8
+       mov       r8,205EA40ADC0
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
-       call      qword ptr [7FFF82D16910]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E2D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,28317C08DC0
+       mov       rdx,205EA40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFF824D4210]
-       mov       rcx,28317C08DC8
+       mov       r8,7FFF82EA86A8
+       call      qword ptr [7FFF824F4210]
+       mov       rcx,205EA40ADC0
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F6F980
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F6F980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF82390E38
+       mov       r11,7FFF823B1300
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51A18
+       mov       rdx,7FFF82F6F8A8
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
-       call      qword ptr [7FFF82734F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82734F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF82390E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF823B1308
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
-       mov       r11,7FFF82390E40
+       mov       r11,7FFF823B1308
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
-       mov       rax,[rdx+38]
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,28317C08DC8
+       mov       r8,189F8C0ADC0
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
-       call      qword ptr [7FFF82D16910]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0DDE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,28317C08DC0
+       mov       rdx,189F8C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFF82E88D20
        call      qword ptr [7FFF824D4210]
-       mov       rcx,28317C08DC8
+       mov       rcx,189F8C0ADC0
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F4F830
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51AF0
+       mov       rdx,7FFF82F4F830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF82390E38
+       mov       r11,7FFF82391340
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
-       call      qword ptr [7FFF82DA5D10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F51A18
+       mov       rdx,7FFF82F4F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FFF82390E40
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
-       mov       r11,7FFF82390E40
+       mov       r11,7FFF82391348
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
-       mov       rax,[rdx+38]
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
+; Total bytes of code 608
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,17F90C0ADC0
+       mov       r8,1AA5040ADC0
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
-       call      qword ptr [7FFF82D8CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0E748]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,17F90C0ADB8
+       mov       rdx,1AA5040ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFF82E83AC8
+       mov       r8,7FFF82E89F08
        call      qword ptr [7FFF824D4210]
-       mov       rcx,17F90C0ADC0
+       mov       rcx,1AA5040ADC0
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
-       mov       rdx,7FFF82E83AC8
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C638
+       mov       rdx,7FFF82F60AD8
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
-       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFF82E83AC8
+       mov       rdx,7FFF82E89F08
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C638
+       mov       rdx,7FFF82F60AD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF82391038
+       mov       r11,7FFF823912B8
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
-       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C560
+       mov       rdx,7FFF82F60A00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFF82391040
+       mov       r11,7FFF823912C0
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
-       mov       r11,7FFF82391040
+       mov       r11,7FFF823912C0
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,17F90C0ADC0
+       mov       r8,205EA40ADC0
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
-       call      qword ptr [7FFF82D8CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E2D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,17F90C0ADB8
+       mov       rdx,205EA40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFF82E83AC8
-       call      qword ptr [7FFF824D4210]
-       mov       rcx,17F90C0ADC0
+       mov       r8,7FFF82EA86A8
+       call      qword ptr [7FFF824F4210]
+       mov       rcx,205EA40ADC0
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
-       mov       rdx,7FFF82E83AC8
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C638
+       mov       rdx,7FFF82F6F980
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
-       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFF82E83AC8
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C638
+       mov       rdx,7FFF82F6F980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF82391038
+       mov       r11,7FFF823B1300
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
-       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C560
+       mov       rdx,7FFF82F6F8A8
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
-       call      qword ptr [7FFF82734F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82734F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFF82391040
+       mov       r11,7FFF823B1308
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
-       mov       r11,7FFF82391040
+       mov       r11,7FFF823B1308
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,17F90C0ADC0
+       mov       r8,189F8C0ADC0
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
-       call      qword ptr [7FFF82D8CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0DDE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,17F90C0ADB8
+       mov       rdx,189F8C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFF82E83AC8
+       mov       r8,7FFF82E88D20
        call      qword ptr [7FFF824D4210]
-       mov       rcx,17F90C0ADC0
+       mov       rcx,189F8C0ADC0
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
-       mov       rdx,7FFF82E83AC8
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C638
+       mov       rdx,7FFF82F4F830
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
-       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFF82E83AC8
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C638
+       mov       rdx,7FFF82F4F830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF82391038
+       mov       r11,7FFF82391340
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
-       call      qword ptr [7FFF82E87E58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F4C560
+       mov       rdx,7FFF82F4F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFF82391040
+       mov       r11,7FFF82391348
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
-       mov       r11,7FFF82391040
+       mov       r11,7FFF82391348
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1AA5040ADC0
+       mov       r8,205EA40ADC0
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
-       call      qword ptr [7FFF82E0E748]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E2D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1AA5040ADB8
+       mov       rdx,205EA40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFF82E89F08
-       call      qword ptr [7FFF824D4210]
-       mov       rcx,1AA5040ADC0
+       mov       r8,7FFF82EA86A8
+       call      qword ptr [7FFF824F4210]
+       mov       rcx,205EA40ADC0
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
-       mov       rdx,7FFF82E89F08
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F60AD8
+       mov       rdx,7FFF82F6F980
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
-       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFF82E89F08
+       mov       rdx,7FFF82EA86A8
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F60AD8
+       mov       rdx,7FFF82F6F980
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823912B8
+       mov       r11,7FFF823B1300
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
-       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F60A00
+       mov       rdx,7FFF82F6F8A8
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
-       call      qword ptr [7FFF82734F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82734F30]
+       call      qword ptr [7FFF82754F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFF823912C0
+       mov       r11,7FFF823B1308
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
-       mov       r11,7FFF823912C0
+       mov       r11,7FFF823B1308
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1AA5040ADC0
+       mov       r8,189F8C0ADC0
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
-       call      qword ptr [7FFF82E0E748]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0DDE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1AA5040ADB8
+       mov       rdx,189F8C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFF82E89F08
+       mov       r8,7FFF82E88D20
        call      qword ptr [7FFF824D4210]
-       mov       rcx,1AA5040ADC0
+       mov       rcx,189F8C0ADC0
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
-       mov       rdx,7FFF82E89F08
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F60AD8
+       mov       rdx,7FFF82F4F830
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
-       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFF82E89F08
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F60AD8
+       mov       rdx,7FFF82F4F830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823912B8
+       mov       r11,7FFF82391340
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
-       call      qword ptr [7FFF82E8E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F60A00
+       mov       rdx,7FFF82F4F758
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFF823912C0
+       mov       r11,7FFF82391348
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
-       mov       r11,7FFF823912C0
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,205EA40ADC0
+       mov       r8,189F8C0ADC0
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
-       call      qword ptr [7FFF82E2D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFF82E0DDE8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,205EA40ADB8
+       mov       rdx,189F8C0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFF82EA86A8
-       call      qword ptr [7FFF824F4210]
-       mov       rcx,205EA40ADC0
+       mov       r8,7FFF82E88D20
+       call      qword ptr [7FFF824D4210]
+       mov       rcx,189F8C0ADC0
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
-       mov       rdx,7FFF82EA86A8
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L04
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L05
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L05
        jmp       near ptr M01_L14
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FFF82F6F980
+       mov       rdx,7FFF82F4F830
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
-       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FFF82EA86A8
+       mov       rdx,7FFF82E88D20
        cmp       [rbx+18],rdx
        jne       short M01_L10
        mov       r15,[rax+38]
        test      r15,r15
        mov       rax,[rbp-38]
        je        short M01_L11
        mov       edx,[r15+8]
        test      edx,edx
        je        short M01_L11
        jmp       near ptr M01_L14
 M01_L08:
        mov       rcx,rsi
-       mov       rdx,7FFF82F6F980
+       mov       rdx,7FFF82F4F830
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FFF823B1300
+       mov       r11,7FFF82391340
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
-       call      qword ptr [7FFF82EACA38]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E8D0B0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FFF82F6F8A8
+       mov       rdx,7FFF82F4F758
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
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FFF82754F30]
+       call      qword ptr [7FFF82734F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FFF823B1308
+       mov       r11,7FFF82391348
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
-       mov       r11,7FFF823B1308
+       mov       rcx,[rbp-38]
+       mov       r11,7FFF82391348
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
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,200A8401F90
+       mov       r8,14D87001F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF829A7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rax,[rdx+78]
+       mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF82504360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+98]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
 M01_L02:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D44C78]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D06208]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B108
+       mov       rdx,7FFF82F3A550
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F3A488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+80]
+       mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D447E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D05D70]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L11:
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+88]
+       mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B080
+       mov       rdx,7FFF82F3A4C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0D0
+       mov       rdx,7FFF82F3A518
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827FC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+90]
+       mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0F0
+       mov       rdx,7FFF82F3A538
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        inc       esi
 M01_L19:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+78]
+       mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F3A488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF829A7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rdx,[rdx+70]
+       mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F6AFD0
+       mov       rdx,7FFF82F3A418
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82846C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827666E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 833
+; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M02_L10
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,r14
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       [rsp+28],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+40],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       ebx,ebx
        lzcnt     ebx,ecx
        xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        add       ebx,ebx
        js        near ptr M02_L09
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rsp+30],rsi
        xor       ecx,ecx
        mov       [rsp+38],rcx
        mov       byte ptr [rsp+44],0
        lea       rcx,[rsp+28]
        mov       rdx,r14
-       call      qword ptr [7FFF82DC64C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82D87D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r15+8]
        lea       rsi,[rsp+28]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
        mov       rbx,[r15]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,r14
        jne       short M02_L11
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
        xor       eax,eax
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L09:
        mov       ecx,87B
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       ecx,ebx
-       call      qword ptr [7FFF82DCFA08]
+       call      qword ptr [7FFF82DC54E8]
        int       3
 M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823C0D40
+       mov       r11,7FFF82390D58
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M02_L00
 M02_L11:
        mov       rcx,r15
-       mov       r11,7FFF823C0D48
+       mov       r11,7FFF82390D60
        call      qword ptr [r11]
        jmp       short M02_L05
 ; Total bytes of code 428
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,200A8401F90
+       mov       r8,241CA401F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF829A7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8298C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rax,[rdx+78]
+       mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF82504360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+98]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
 M01_L02:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D44C78]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D16220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B108
+       mov       rdx,7FFF82F4A5A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F4A4E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+80]
+       mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D447E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D15D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L11:
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+88]
+       mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B080
+       mov       rdx,7FFF82F4A520
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0D0
+       mov       rdx,7FFF82F4A570
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827FC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827DC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+90]
+       mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0F0
+       mov       rdx,7FFF82F4A590
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        inc       esi
 M01_L19:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+78]
+       mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F4A4E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF829A7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8298CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rdx,[rdx+70]
+       mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F6AFD0
+       mov       rdx,7FFF82F4A470
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82846C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82826C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF8270F3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827666E8]
+       call      qword ptr [7FFF827466E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 833
+; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M02_L10
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,r14
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       [rsp+28],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+40],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       ebx,ebx
        lzcnt     ebx,ecx
        xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        add       ebx,ebx
        js        near ptr M02_L09
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rsp+30],rsi
        xor       ecx,ecx
        mov       [rsp+38],rcx
        mov       byte ptr [rsp+44],0
        lea       rcx,[rsp+28]
        mov       rdx,r14
-       call      qword ptr [7FFF82DC64C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82D97B10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r15+8]
        lea       rsi,[rsp+28]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
        mov       rbx,[r15]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,r14
        jne       short M02_L11
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
        xor       eax,eax
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L09:
        mov       ecx,87B
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF8270F3A8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       ecx,ebx
-       call      qword ptr [7FFF82DCFA08]
+       call      qword ptr [7FFF82DD51A0]
        int       3
 M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823C0D40
+       mov       r11,7FFF823A0C98
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M02_L00
 M02_L11:
        mov       rcx,r15
-       mov       r11,7FFF823C0D48
+       mov       r11,7FFF823A0CA0
        call      qword ptr [r11]
        jmp       short M02_L05
 ; Total bytes of code 428
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,200A8401F90
+       mov       r8,1CC76401F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF829A7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rax,[rdx+78]
+       mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF82504360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+98]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
 M01_L02:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D44C78]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D04A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B108
+       mov       rdx,7FFF82F39BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F39B28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+80]
+       mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F39B68
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D447E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D045A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L11:
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+88]
+       mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F6B080
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0D0
+       mov       rdx,7FFF82F39BB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827FC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+90]
+       mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0F0
+       mov       rdx,7FFF82F39BD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        inc       esi
 M01_L19:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+78]
+       mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F39B28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF829A7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rdx,[rdx+70]
+       mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F6AFD0
+       mov       rdx,7FFF82F39AB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82846C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827666E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 833
+; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M02_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,20D08279CB0
+       call      qword ptr [7FFF8286FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DC64C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82D964C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M02_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M02_L04
        jmp       short M02_L02
 M02_L01:
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M02_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
 M02_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8272F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DCFA08]
-       int       3
-M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823C0D40
+       mov       r11,7FFF82390C98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D48
+M02_L10:
+       mov       rcx,r14
+       mov       r11,7FFF82390CA0
        call      qword ptr [r11]
        jmp       short M02_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,200A8401F90
+       mov       r8,1FF18401F98
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF829A7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8296C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8296CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rax,[rdx+78]
+       mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF82504360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+98]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
 M01_L02:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D44C78]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D761A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B108
+       mov       rdx,7FFF82F50C30
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+80]
+       mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F50BA8
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D447E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D75D10]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L11:
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+88]
+       mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F6B080
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0D0
+       mov       rdx,7FFF82F50BF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827FC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827BC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+90]
+       mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0F0
+       mov       rdx,7FFF82F50C18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        inc       esi
 M01_L19:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+78]
+       mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF829A7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8296CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rdx,[rdx+70]
+       mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F6AFD0
+       mov       rdx,7FFF82F50AF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82846C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82806C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF826EF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827666E8]
+       call      qword ptr [7FFF827266E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 833
+; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M02_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,23FA6479CB0
+       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DC64C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82E77D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M02_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M02_L04
        jmp       short M02_L02
 M02_L01:
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M02_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
 M02_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8272F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DCFA08]
-       int       3
-M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823C0D40
+       mov       r11,7FFF82380E10
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D48
+M02_L10:
+       mov       rcx,r14
+       mov       r11,7FFF82380E18
        call      qword ptr [r11]
        jmp       short M02_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,200A8401F90
+       mov       r8,150FE001FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF829A7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rax,[rdx+78]
+       mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF82504360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+98]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
 M01_L02:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D44C78]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B108
+       mov       rdx,7FFF82F614C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+80]
+       mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F61438
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D447E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L11:
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+88]
+       mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F6B080
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0D0
+       mov       rdx,7FFF82F61488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827FC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+90]
+       mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0F0
+       mov       rdx,7FFF82F614A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        inc       esi
 M01_L19:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+78]
+       mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF829A7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rdx,[rdx+70]
+       mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F6AFD0
+       mov       rdx,7FFF82F61388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82846C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C600]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827666E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 833
+; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DC64C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390898
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M02_L01
-       jmp       short M02_L06
+       add       esi,1
+       jo        near ptr M02_L07
 M02_L03:
-       add       ebp,1
-       jo        short M02_L07
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M02_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908A0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L03
+       jne       short M02_L02
+       jmp       short M02_L06
+M02_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8272F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DCFA08]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823C0D40
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D48
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,200A8401F90
+       mov       r8,152CC401FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF829A7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rax,[rdx+78]
+       mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF82504360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+98]
+       mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
 M01_L02:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D44C78]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C9D8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B108
+       mov       rdx,7FFF82F61008
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+80]
+       mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F60F80
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D447E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E0C540]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L11:
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+88]
+       mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F6B080
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0D0
+       mov       rdx,7FFF82F60FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827FC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+90]
+       mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0F0
+       mov       rdx,7FFF82F60FF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        inc       esi
 M01_L19:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+78]
+       mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF829A7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rdx,[rdx+70]
+       mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F6AFD0
+       mov       rdx,7FFF82F60ED0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82846C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827666E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 833
+; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       je        short M02_L01
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
+M02_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
+M02_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DC64C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L00
+M02_L02:
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
        jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
        jmp       short M02_L02
-M02_L01:
-       add       ebp,1
-       jo        short M02_L07
-M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF82390890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8272F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DCFA08]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823C0D40
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D48
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,200A8401F90
+       mov       r8,23CD9801FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF829A7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF829AC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rax,[rdx+78]
+       mov       rax,[rdx+68]
        test      rax,rax
-       je        near ptr M01_L07
+       je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF82504360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
-       mov       r15,rax
-       test      r15,r15
-       je        near ptr M01_L08
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       mov       rdi,rax
+       test      rdi,rdi
+       je        near ptr M01_L09
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rax,[rcx+98]
+       mov       rax,[rcx+88]
        test      rax,rax
-       je        short M01_L06
+       je        near ptr M01_L07
 M01_L02:
-       mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
-       je        near ptr M01_L08
+       mov       rcx,rdi
+       mov       r15,[rcx]
+       cmp       r15,rax
+       je        near ptr M01_L09
        mov       rcx,[rbx+10]
-       cmp       rcx,[r15+10]
+       cmp       rcx,[rdi+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
-       cmp       r13,rcx
+       cmp       r15,rcx
        je        short M01_L04
-       mov       rcx,r15
+       mov       rcx,rdi
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15+48]
        call      qword ptr [rax+10]
 M01_L04:
-       mov       ecx,[r15+20]
+       mov       ecx,[rdi+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
-       mov       rcx,[r15+8]
+       mov       rcx,[rdi+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D44C78]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rcx,r14
-       mov       rdx,7FFF82F6B108
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp       near ptr M01_L02
-M01_L07:
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
+M01_L07:
+       mov       rcx,r14
+       mov       rdx,7FFF82F62368
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp       near ptr M01_L02
 M01_L08:
+       test      eax,eax
+       jne       near ptr M01_L03
+M01_L09:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+80]
+       mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
-M01_L09:
+       je        short M01_L10
+       jmp       short M01_L11
+M01_L10:
+       mov       rcx,r14
+       mov       rdx,7FFF82F622E0
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
+M01_L11:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D447E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       rsi,rax
        cmp       dword ptr [rsp+30],0
-       jg        short M01_L11
-M01_L10:
-       add       rsp,40
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r13
-       pop       r14
-       pop       r15
-       ret
-M01_L11:
+       jle       near ptr M01_L21
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+88]
+       mov       rcx,[rcx+78]
        test      rcx,rcx
-       je        short M01_L13
-       jmp       short M01_L14
+       je        short M01_L12
+       jmp       short M01_L13
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B080
+       mov       rdx,7FFF82F62330
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-       jmp       short M01_L09
 M01_L13:
-       mov       rcx,r14
-       mov       rdx,7FFF82F6B0D0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
-M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r13
+       mov       rdx,rsi
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827FC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC7F8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       mov       ebp,1
        mov       r15d,1
-       mov       esi,1
-       jmp       near ptr M01_L19
-M01_L15:
+       jmp       near ptr M01_L18
+M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       r11,[rcx+90]
+       mov       r11,[rcx+80]
        test      r11,r11
-       je        short M01_L16
-       jmp       short M01_L17
-M01_L16:
+       je        short M01_L15
+       jmp       short M01_L16
+M01_L15:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B0F0
+       mov       rdx,7FFF82F62350
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
-M01_L17:
-       cmp       esi,[r13+8]
+M01_L16:
+       cmp       r15d,[rsi+8]
        jae       near ptr M01_L27
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r15d
+       mov       rdx,[rsi+rdx*8+10]
+       lea       r8d,[r15-1]
+       cmp       r8d,[rsi+8]
        jae       near ptr M01_L27
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r15-1]
+       mov       r8,[rsi+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
-       je        short M01_L18
-       lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
-       jae       near ptr M01_L27
+       je        short M01_L17
+       lea       ecx,[rbp+1]
+       mov       r13d,ecx
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       mov       rdx,[rsi+rcx*8+10]
+       cmp       ebp,[rsi+8]
+       jae       near ptr M01_L27
+       mov       ecx,ebp
+       lea       rcx,[rsi+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       ebp,r13d
+M01_L17:
+       inc       r15d
 M01_L18:
-       inc       esi
-M01_L19:
-       cmp       esi,[rsp+30]
-       jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       cmp       r15d,[rsp+30]
+       jl        near ptr M01_L14
+       mov       [rsp+30],ebp
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
-       mov       rcx,[rcx+78]
+       mov       rcx,[rcx+68]
        test      rcx,rcx
-       je        short M01_L20
-       jmp       short M01_L21
-M01_L20:
+       je        short M01_L19
+       jmp       short M01_L20
+M01_L19:
        mov       rcx,r14
-       mov       rdx,7FFF82F6B040
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L21:
+M01_L20:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,rsi
        xor       r8d,r8d
-       call      qword ptr [7FFF829A7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
-       jmp       near ptr M01_L10
+M01_L21:
+       add       rsp,40
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
+       ret
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
-       mov       rdx,[rdx+70]
+       mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F6AFD0
+       mov       rdx,7FFF82F62230
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82846C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8282C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8272F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827666E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
-       mov       rdx,[r15+10]
+       mov       rdx,[rdi+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
-       test      eax,eax
-       je        near ptr M01_L08
-       jmp       near ptr M01_L03
+       jmp       near ptr M01_L08
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 833
+; Total bytes of code 830
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DC64C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908A8
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M02_L01
-       jmp       short M02_L06
+       add       esi,1
+       jo        near ptr M02_L07
 M02_L03:
-       add       ebp,1
-       jo        short M02_L07
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DC64F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M02_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L03
+       jne       short M02_L02
+       jmp       short M02_L06
+M02_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8272F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DCFA08]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823C0D40
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D48
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,14D87001F90
+       mov       r8,241CA401F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8298C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D06208]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D16220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A550
+       mov       rdx,7FFF82F4A5A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F4A4E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D05D70]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D15D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A4C8
+       mov       rdx,7FFF82F4A520
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A518
+       mov       rdx,7FFF82F4A570
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827DC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A538
+       mov       rdx,7FFF82F4A590
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F4A4E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8298CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F3A418
+       mov       rdx,7FFF82F4A470
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82826C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF826FF3A8
+       mov       rdx,7FFF8270F3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827366E8]
+       call      qword ptr [7FFF827466E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M02_L10
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,r14
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       [rsp+28],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+40],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       ebx,ebx
        lzcnt     ebx,ecx
        xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        add       ebx,ebx
        js        near ptr M02_L09
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rsp+30],rsi
        xor       ecx,ecx
        mov       [rsp+38],rcx
        mov       byte ptr [rsp+44],0
        lea       rcx,[rsp+28]
        mov       rdx,r14
-       call      qword ptr [7FFF82D87D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82D97B10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r15+8]
        lea       rsi,[rsp+28]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
        mov       rbx,[r15]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,r14
        jne       short M02_L11
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
        xor       eax,eax
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M02_L09:
        mov       ecx,87B
-       mov       rdx,7FFF826FF3A8
+       mov       rdx,7FFF8270F3A8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       ecx,ebx
-       call      qword ptr [7FFF82DC54E8]
+       call      qword ptr [7FFF82DD51A0]
        int       3
 M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF82390D58
+       mov       r11,7FFF823A0C98
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M02_L00
 M02_L11:
        mov       rcx,r15
-       mov       r11,7FFF82390D60
+       mov       r11,7FFF823A0CA0
        call      qword ptr [r11]
        jmp       short M02_L05
 ; Total bytes of code 428
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,14D87001F90
+       mov       r8,1CC76401F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D06208]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D04A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A550
+       mov       rdx,7FFF82F39BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F39B28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F39B68
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D05D70]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D045A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F3A4C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A518
+       mov       rdx,7FFF82F39BB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A538
+       mov       rdx,7FFF82F39BD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F39B28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F3A418
+       mov       rdx,7FFF82F39AB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M02_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,20D08279CB0
+       call      qword ptr [7FFF8286FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D87D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82D964C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M02_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M02_L04
        jmp       short M02_L02
 M02_L01:
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M02_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
 M02_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF826FF3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DC54E8]
-       int       3
-M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF82390D58
+       mov       r11,7FFF82390C98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF82390D60
+M02_L10:
+       mov       rcx,r14
+       mov       r11,7FFF82390CA0
        call      qword ptr [r11]
        jmp       short M02_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,14D87001F90
+       mov       r8,1FF18401F98
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8296C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8296CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D06208]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D761A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A550
+       mov       rdx,7FFF82F50C30
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F50BA8
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D05D70]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D75D10]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F3A4C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A518
+       mov       rdx,7FFF82F50BF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827BC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A538
+       mov       rdx,7FFF82F50C18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8296CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F3A418
+       mov       rdx,7FFF82F50AF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82806C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF826FF3A8
+       mov       rdx,7FFF826EF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827366E8]
+       call      qword ptr [7FFF827266E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M02_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,23FA6479CB0
+       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D87D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82E77D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M02_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M02_L04
        jmp       short M02_L02
 M02_L01:
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M02_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
 M02_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF826FF3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DC54E8]
-       int       3
-M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF82390D58
+       mov       r11,7FFF82380E10
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF82390D60
+M02_L10:
+       mov       rcx,r14
+       mov       r11,7FFF82380E18
        call      qword ptr [r11]
        jmp       short M02_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,14D87001F90
+       mov       r8,150FE001FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D06208]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A550
+       mov       rdx,7FFF82F614C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F61438
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D05D70]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F3A4C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A518
+       mov       rdx,7FFF82F61488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A538
+       mov       rdx,7FFF82F614A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F3A418
+       mov       rdx,7FFF82F61388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C600]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D87D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390898
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M02_L01
-       jmp       short M02_L06
+       add       esi,1
+       jo        near ptr M02_L07
 M02_L03:
-       add       ebp,1
-       jo        short M02_L07
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M02_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908A0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L03
+       jne       short M02_L02
+       jmp       short M02_L06
+M02_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF826FF3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DC54E8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF82390D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF82390D60
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,14D87001F90
+       mov       r8,152CC401FC0
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
        call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D06208]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C9D8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A550
+       mov       rdx,7FFF82F61008
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F60F80
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D05D70]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E0C540]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F3A4C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A518
+       mov       rdx,7FFF82F60FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A538
+       mov       rdx,7FFF82F60FF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F3A418
+       mov       rdx,7FFF82F60ED0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       je        short M02_L01
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
+M02_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
+M02_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D87D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L00
+M02_L02:
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
        jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
        jmp       short M02_L02
-M02_L01:
-       add       ebp,1
-       jo        short M02_L07
-M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF82390890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF826FF3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DC54E8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF82390D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF82390D60
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,14D87001F90
+       mov       r8,23CD9801FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
-       je        near ptr M01_L07
+       je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
-       mov       r15,rax
-       test      r15,r15
-       je        near ptr M01_L08
+       mov       rdi,rax
+       test      rdi,rdi
+       je        near ptr M01_L09
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
-       je        short M01_L06
+       je        near ptr M01_L07
 M01_L02:
-       mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
-       je        near ptr M01_L08
+       mov       rcx,rdi
+       mov       r15,[rcx]
+       cmp       r15,rax
+       je        near ptr M01_L09
        mov       rcx,[rbx+10]
-       cmp       rcx,[r15+10]
+       cmp       rcx,[rdi+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
-       cmp       r13,rcx
+       cmp       r15,rcx
        je        short M01_L04
-       mov       rcx,r15
+       mov       rcx,rdi
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15+48]
        call      qword ptr [rax+10]
 M01_L04:
-       mov       ecx,[r15+20]
+       mov       ecx,[rdi+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
-       mov       rcx,[r15+8]
+       mov       rcx,[rdi+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D06208]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rcx,r14
-       mov       rdx,7FFF82F3A550
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp       near ptr M01_L02
-M01_L07:
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
+M01_L07:
+       mov       rcx,r14
+       mov       rdx,7FFF82F62368
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp       near ptr M01_L02
 M01_L08:
+       test      eax,eax
+       jne       near ptr M01_L03
+M01_L09:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
-M01_L09:
+       je        short M01_L10
+       jmp       short M01_L11
+M01_L10:
+       mov       rcx,r14
+       mov       rdx,7FFF82F622E0
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
+M01_L11:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D05D70]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       rsi,rax
        cmp       dword ptr [rsp+30],0
-       jg        short M01_L11
-M01_L10:
-       add       rsp,40
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r13
-       pop       r14
-       pop       r15
-       ret
-M01_L11:
+       jle       near ptr M01_L21
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
-       je        short M01_L13
-       jmp       short M01_L14
+       je        short M01_L12
+       jmp       short M01_L13
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A4C8
+       mov       rdx,7FFF82F62330
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-       jmp       short M01_L09
 M01_L13:
-       mov       rcx,r14
-       mov       rdx,7FFF82F3A518
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
-M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r13
+       mov       rdx,rsi
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC7F8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       mov       ebp,1
        mov       r15d,1
-       mov       esi,1
-       jmp       near ptr M01_L19
-M01_L15:
+       jmp       near ptr M01_L18
+M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
-       je        short M01_L16
-       jmp       short M01_L17
-M01_L16:
+       je        short M01_L15
+       jmp       short M01_L16
+M01_L15:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A538
+       mov       rdx,7FFF82F62350
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
-M01_L17:
-       cmp       esi,[r13+8]
+M01_L16:
+       cmp       r15d,[rsi+8]
        jae       near ptr M01_L27
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r15d
+       mov       rdx,[rsi+rdx*8+10]
+       lea       r8d,[r15-1]
+       cmp       r8d,[rsi+8]
        jae       near ptr M01_L27
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r15-1]
+       mov       r8,[rsi+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
-       je        short M01_L18
-       lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
-       jae       near ptr M01_L27
+       je        short M01_L17
+       lea       ecx,[rbp+1]
+       mov       r13d,ecx
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       mov       rdx,[rsi+rcx*8+10]
+       cmp       ebp,[rsi+8]
+       jae       near ptr M01_L27
+       mov       ecx,ebp
+       lea       rcx,[rsi+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       ebp,r13d
+M01_L17:
+       inc       r15d
 M01_L18:
-       inc       esi
-M01_L19:
-       cmp       esi,[rsp+30]
-       jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       cmp       r15d,[rsp+30]
+       jl        near ptr M01_L14
+       mov       [rsp+30],ebp
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
-       je        short M01_L20
-       jmp       short M01_L21
-M01_L20:
+       je        short M01_L19
+       jmp       short M01_L20
+M01_L19:
        mov       rcx,r14
-       mov       rdx,7FFF82F3A488
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L21:
+M01_L20:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,rsi
        xor       r8d,r8d
-       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
-       jmp       near ptr M01_L10
+M01_L21:
+       add       rsp,40
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
+       ret
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F3A418
+       mov       rdx,7FFF82F62230
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8282C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       ecx,7D7
        mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
-       mov       rdx,[r15+10]
+       mov       rdx,[rdi+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
-       test      eax,eax
-       je        near ptr M01_L08
-       jmp       near ptr M01_L03
+       jmp       near ptr M01_L08
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 827
+; Total bytes of code 830
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D87D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908A8
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M02_L01
-       jmp       short M02_L06
+       add       esi,1
+       jo        near ptr M02_L07
 M02_L03:
-       add       ebp,1
-       jo        short M02_L07
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D87D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M02_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L03
+       jne       short M02_L02
+       jmp       short M02_L06
+M02_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF826FF3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DC54E8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF82390D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF82390D60
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,241CA401F90
+       mov       r8,1CC76401F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8298C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D16220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D04A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A5A8
+       mov       rdx,7FFF82F39BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F39B28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F39B68
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D15D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D045A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F4A520
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A570
+       mov       rdx,7FFF82F39BB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827DC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A590
+       mov       rdx,7FFF82F39BD8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F39B28
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8298CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F4A470
+       mov       rdx,7FFF82F39AB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82826C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8270F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827466E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M02_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,20D08279CB0
+       call      qword ptr [7FFF8286FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D97B10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82D964C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M02_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M02_L04
        jmp       short M02_L02
 M02_L01:
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M02_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
 M02_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DD51A0]
-       int       3
-M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823A0C98
+       mov       r11,7FFF82390C98
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0CA0
+M02_L10:
+       mov       rcx,r14
+       mov       r11,7FFF82390CA0
        call      qword ptr [r11]
        jmp       short M02_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,241CA401F90
+       mov       r8,1FF18401F98
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8298C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8296C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8296CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D16220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D761A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A5A8
+       mov       rdx,7FFF82F50C30
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F50BA8
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D15D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D75D10]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F4A520
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A570
+       mov       rdx,7FFF82F50BF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827DC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827BC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A590
+       mov       rdx,7FFF82F50C18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8298CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8296CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F4A470
+       mov       rdx,7FFF82F50AF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82826C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82806C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8270F3A8
+       mov       rdx,7FFF826EF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827466E8]
+       call      qword ptr [7FFF827266E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M02_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,23FA6479CB0
+       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D97B10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82E77D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M02_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M02_L04
        jmp       short M02_L02
 M02_L01:
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M02_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
 M02_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DD51A0]
-       int       3
-M02_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823A0C98
+       mov       r11,7FFF82380E10
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0CA0
+M02_L10:
+       mov       rcx,r14
+       mov       r11,7FFF82380E18
        call      qword ptr [r11]
        jmp       short M02_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,241CA401F90
+       mov       r8,150FE001FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8298C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D16220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A5A8
+       mov       rdx,7FFF82F614C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F61438
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D15D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F4A520
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A570
+       mov       rdx,7FFF82F61488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827DC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A590
+       mov       rdx,7FFF82F614A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8298CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F4A470
+       mov       rdx,7FFF82F61388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82826C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C600]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8270F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827466E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D97B10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390898
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M02_L01
-       jmp       short M02_L06
+       add       esi,1
+       jo        near ptr M02_L07
 M02_L03:
-       add       ebp,1
-       jo        short M02_L07
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M02_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908A0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L03
+       jne       short M02_L02
+       jmp       short M02_L06
+M02_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DD51A0]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0C98
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0CA0
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,241CA401F90
+       mov       r8,152CC401FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8298C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D16220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C9D8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A5A8
+       mov       rdx,7FFF82F61008
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FFF82F60F80
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D15D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E0C540]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FFF82F4A520
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A570
+       mov       rdx,7FFF82F60FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827DC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A590
+       mov       rdx,7FFF82F60FF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8298CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F4A470
+       mov       rdx,7FFF82F60ED0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82826C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8270F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827466E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       je        short M02_L01
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
+M02_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
+M02_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D97B10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L00
+M02_L02:
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
        jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
        jmp       short M02_L02
-M02_L01:
-       add       ebp,1
-       jo        short M02_L07
-M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF82390890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DD51A0]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0C98
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0CA0
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,241CA401F90
+       mov       r8,23CD9801FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8298C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
-       je        near ptr M01_L07
+       je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
-       mov       r15,rax
-       test      r15,r15
-       je        near ptr M01_L08
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       mov       rdi,rax
+       test      rdi,rdi
+       je        near ptr M01_L09
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
-       je        short M01_L06
+       je        near ptr M01_L07
 M01_L02:
-       mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
-       je        near ptr M01_L08
+       mov       rcx,rdi
+       mov       r15,[rcx]
+       cmp       r15,rax
+       je        near ptr M01_L09
        mov       rcx,[rbx+10]
-       cmp       rcx,[r15+10]
+       cmp       rcx,[rdi+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
-       cmp       r13,rcx
+       cmp       r15,rcx
        je        short M01_L04
-       mov       rcx,r15
+       mov       rcx,rdi
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15+48]
        call      qword ptr [rax+10]
 M01_L04:
-       mov       ecx,[r15+20]
+       mov       ecx,[rdi+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
-       mov       rcx,[r15+8]
+       mov       rcx,[rdi+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D16220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rcx,r14
-       mov       rdx,7FFF82F4A5A8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp       near ptr M01_L02
-M01_L07:
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
+M01_L07:
+       mov       rcx,r14
+       mov       rdx,7FFF82F62368
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp       near ptr M01_L02
 M01_L08:
+       test      eax,eax
+       jne       near ptr M01_L03
+M01_L09:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       je        short M01_L12
-M01_L09:
+       je        short M01_L10
+       jmp       short M01_L11
+M01_L10:
+       mov       rcx,r14
+       mov       rdx,7FFF82F622E0
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
+M01_L11:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D15D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       rsi,rax
        cmp       dword ptr [rsp+30],0
-       jg        short M01_L11
-M01_L10:
-       add       rsp,40
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r13
-       pop       r14
-       pop       r15
-       ret
-M01_L11:
+       jle       near ptr M01_L21
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
-       je        short M01_L13
-       jmp       short M01_L14
+       je        short M01_L12
+       jmp       short M01_L13
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A520
+       mov       rdx,7FFF82F62330
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-       jmp       short M01_L09
 M01_L13:
-       mov       rcx,r14
-       mov       rdx,7FFF82F4A570
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
-M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r13
+       mov       rdx,rsi
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827DC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC7F8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       mov       ebp,1
        mov       r15d,1
-       mov       esi,1
-       jmp       near ptr M01_L19
-M01_L15:
+       jmp       near ptr M01_L18
+M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
-       je        short M01_L16
-       jmp       short M01_L17
-M01_L16:
+       je        short M01_L15
+       jmp       short M01_L16
+M01_L15:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A590
+       mov       rdx,7FFF82F62350
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
-M01_L17:
-       cmp       esi,[r13+8]
+M01_L16:
+       cmp       r15d,[rsi+8]
        jae       near ptr M01_L27
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r15d
+       mov       rdx,[rsi+rdx*8+10]
+       lea       r8d,[r15-1]
+       cmp       r8d,[rsi+8]
        jae       near ptr M01_L27
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r15-1]
+       mov       r8,[rsi+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
-       je        short M01_L18
-       lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
-       jae       near ptr M01_L27
+       je        short M01_L17
+       lea       ecx,[rbp+1]
+       mov       r13d,ecx
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       mov       rdx,[rsi+rcx*8+10]
+       cmp       ebp,[rsi+8]
+       jae       near ptr M01_L27
+       mov       ecx,ebp
+       lea       rcx,[rsi+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       ebp,r13d
+M01_L17:
+       inc       r15d
 M01_L18:
-       inc       esi
-M01_L19:
-       cmp       esi,[rsp+30]
-       jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       cmp       r15d,[rsp+30]
+       jl        near ptr M01_L14
+       mov       [rsp+30],ebp
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
-       je        short M01_L20
-       jmp       short M01_L21
-M01_L20:
+       je        short M01_L19
+       jmp       short M01_L20
+M01_L19:
        mov       rcx,r14
-       mov       rdx,7FFF82F4A4E0
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L21:
+M01_L20:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,rsi
        xor       r8d,r8d
-       call      qword ptr [7FFF8298CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
-       jmp       near ptr M01_L10
+M01_L21:
+       add       rsp,40
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
+       ret
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F4A470
+       mov       rdx,7FFF82F62230
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82826C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8282C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF8270F3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827466E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
-       mov       rdx,[r15+10]
+       mov       rdx,[rdi+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
-       test      eax,eax
-       je        near ptr M01_L08
-       jmp       near ptr M01_L03
+       jmp       near ptr M01_L08
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 827
+; Total bytes of code 830
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M02_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M02_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D97B10]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r15,r15
-       je        short M02_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908A8
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M02_L01
-       jmp       short M02_L06
+       add       esi,1
+       jo        near ptr M02_L07
 M02_L03:
-       add       ebp,1
-       jo        short M02_L07
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
 M02_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M02_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D97B40]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M02_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L03
+       jne       short M02_L02
+       jmp       short M02_L06
+M02_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L07:
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M02_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DD51A0]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M02_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0C98
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M02_L00
-M02_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0CA0
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,1CC76401F90
+       mov       r8,1FF18401F98
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8296C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8296CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D04A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82D761A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BF0
+       mov       rdx,7FFF82F50C30
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FFF82F39B68
+       mov       rdx,7FFF82F50BA8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D045A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82D75D10]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BB8
+       mov       rdx,7FFF82F50BF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827BC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BD8
+       mov       rdx,7FFF82F50C18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F50B68
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8296CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F39AB8
+       mov       rdx,7FFF82F50AF8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF8281C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82806C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF826FF3A8
+       mov       rdx,7FFF826EF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827366E8]
+       call      qword ptr [7FFF827266E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M02_L09
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       r14,rax
        mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       esi,esi
        lzcnt     esi,ecx
        xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        add       esi,esi
        mov       ecx,esi
-       mov       rdx,20D08279CB0
-       call      qword ptr [7FFF8286FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       mov       rdx,23FA6479CB0
+       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
        movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rsp+28],rdi
        xor       ecx,ecx
        mov       [rsp+30],rcx
        mov       byte ptr [rsp+3C],0
        lea       rcx,[rsp+20]
        mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82D964C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82E77D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r14+8]
        lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M02_L07
 M02_L02:
        mov       rdx,rbx
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M02_L01
        jmp       short M02_L06
        add       ebp,1
        jo        short M02_L07
 M02_L04:
        mov       rbx,[r14]
        mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,rdx
        jne       short M02_L10
        mov       rdx,rbx
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
        test      eax,eax
        jne       short M02_L03
        xor       eax,eax
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M02_L09:
        mov       rcx,rbx
-       mov       r11,7FFF82390C98
+       mov       r11,7FFF82380E10
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M02_L00
 M02_L10:
        mov       rcx,r14
-       mov       r11,7FFF82390CA0
+       mov       r11,7FFF82380E18
        call      qword ptr [r11]
        jmp       short M02_L05
 ; Total bytes of code 400
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,1CC76401F90
+       mov       r8,150FE001FC0
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
        call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D04A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BF0
+       mov       rdx,7FFF82F614C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FFF82F39B68
+       mov       rdx,7FFF82F61438
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D045A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BB8
+       mov       rdx,7FFF82F61488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BD8
+       mov       rdx,7FFF82F614A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F39AB8
+       mov       rdx,7FFF82F61388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF8281C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C600]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M02_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,20D08279CB0
-       call      qword ptr [7FFF8286FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82D964C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r14,r14
-       je        short M02_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390898
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823908A0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M02_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF82390C98
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M02_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M02_L10:
-       mov       rcx,r14
-       mov       r11,7FFF82390CA0
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,1CC76401F90
+       mov       r8,152CC401FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D04A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C9D8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BF0
+       mov       rdx,7FFF82F61008
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FFF82F39B68
+       mov       rdx,7FFF82F60F80
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D045A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E0C540]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BB8
+       mov       rdx,7FFF82F60FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BD8
+       mov       rdx,7FFF82F60FF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F39AB8
+       mov       rdx,7FFF82F60ED0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF8281C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M02_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
+       cmp       [rbx],rcx
+       je        short M02_L01
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
+M02_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
+M02_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,20D08279CB0
-       call      qword ptr [7FFF8286FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82D964C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M02_L00:
-       test      r14,r14
-       je        short M02_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L04
-       jmp       short M02_L02
-M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L00
 M02_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF82390890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M02_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF82390C98
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M02_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M02_L10:
-       mov       rcx,r14
-       mov       r11,7FFF82390CA0
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,1CC76401F90
+       mov       r8,23CD9801FC0
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
        call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
-       je        near ptr M01_L07
+       je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
-       mov       r15,rax
-       test      r15,r15
-       je        near ptr M01_L08
+       mov       rdi,rax
+       test      rdi,rdi
+       je        near ptr M01_L09
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
-       je        short M01_L06
+       je        near ptr M01_L07
 M01_L02:
-       mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
-       je        near ptr M01_L08
+       mov       rcx,rdi
+       mov       r15,[rcx]
+       cmp       r15,rax
+       je        near ptr M01_L09
        mov       rcx,[rbx+10]
-       cmp       rcx,[r15+10]
+       cmp       rcx,[rdi+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
-       cmp       r13,rcx
+       cmp       r15,rcx
        je        short M01_L04
-       mov       rcx,r15
+       mov       rcx,rdi
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15+48]
        call      qword ptr [rax+10]
 M01_L04:
-       mov       ecx,[r15+20]
+       mov       ecx,[rdi+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
-       mov       rcx,[r15+8]
+       mov       rcx,[rdi+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D04A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rcx,r14
-       mov       rdx,7FFF82F39BF0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp       near ptr M01_L02
-M01_L07:
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
+M01_L07:
+       mov       rcx,r14
+       mov       rdx,7FFF82F62368
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp       near ptr M01_L02
 M01_L08:
+       test      eax,eax
+       jne       near ptr M01_L03
+M01_L09:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       jne       short M01_L12
+       je        short M01_L10
+       jmp       short M01_L11
+M01_L10:
        mov       rcx,r14
-       mov       rdx,7FFF82F39B68
+       mov       rdx,7FFF82F622E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L09:
+M01_L11:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D045A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       rsi,rax
        cmp       dword ptr [rsp+30],0
-       jg        short M01_L11
-M01_L10:
-       add       rsp,40
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r13
-       pop       r14
-       pop       r15
-       ret
-M01_L11:
+       jle       near ptr M01_L21
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
-       je        short M01_L13
-       jmp       short M01_L14
+       je        short M01_L12
+       jmp       short M01_L13
 M01_L12:
-       jmp       short M01_L09
-M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BB8
+       mov       rdx,7FFF82F62330
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L14:
+M01_L13:
        mov       [rsp+20],rdi
-       mov       rdx,r13
+       mov       rdx,rsi
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC7F8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       mov       ebp,1
        mov       r15d,1
-       mov       esi,1
-       jmp       near ptr M01_L19
-M01_L15:
+       jmp       near ptr M01_L18
+M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
-       je        short M01_L16
-       jmp       short M01_L17
-M01_L16:
+       je        short M01_L15
+       jmp       short M01_L16
+M01_L15:
        mov       rcx,r14
-       mov       rdx,7FFF82F39BD8
+       mov       rdx,7FFF82F62350
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
-M01_L17:
-       cmp       esi,[r13+8]
+M01_L16:
+       cmp       r15d,[rsi+8]
        jae       near ptr M01_L27
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r15d
+       mov       rdx,[rsi+rdx*8+10]
+       lea       r8d,[r15-1]
+       cmp       r8d,[rsi+8]
        jae       near ptr M01_L27
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r15-1]
+       mov       r8,[rsi+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
-       je        short M01_L18
-       lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
-       jae       near ptr M01_L27
+       je        short M01_L17
+       lea       ecx,[rbp+1]
+       mov       r13d,ecx
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       mov       rdx,[rsi+rcx*8+10]
+       cmp       ebp,[rsi+8]
+       jae       near ptr M01_L27
+       mov       ecx,ebp
+       lea       rcx,[rsi+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       ebp,r13d
+M01_L17:
+       inc       r15d
 M01_L18:
-       inc       esi
-M01_L19:
-       cmp       esi,[rsp+30]
-       jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       cmp       r15d,[rsp+30]
+       jl        near ptr M01_L14
+       mov       [rsp+30],ebp
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
-       je        short M01_L20
-       jmp       short M01_L21
-M01_L20:
+       je        short M01_L19
+       jmp       short M01_L20
+M01_L19:
        mov       rcx,r14
-       mov       rdx,7FFF82F39B28
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L21:
+M01_L20:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,rsi
        xor       r8d,r8d
        call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
-       jmp       near ptr M01_L10
+M01_L21:
+       add       rsp,40
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
+       ret
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F39AB8
+       mov       rdx,7FFF82F62230
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF8281C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8282C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       ecx,7D7
        mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
-       mov       rdx,[r15+10]
+       mov       rdx,[rdi+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
-       test      eax,eax
-       je        near ptr M01_L08
-       jmp       near ptr M01_L03
+       jmp       near ptr M01_L08
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 827
+; Total bytes of code 830
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M02_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,20D08279CB0
-       call      qword ptr [7FFF8286FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82D964C0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r14,r14
-       je        short M02_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908A8
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823908B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82D964F0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M02_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF82390C98
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M02_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M02_L10:
-       mov       rcx,r14
-       mov       r11,7FFF82390CA0
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,1FF18401F98
+       mov       r8,150FE001FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8296C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8296CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D761A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F50C30
+       mov       rdx,7FFF82F614C0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F50B68
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FFF82F50BA8
+       mov       rdx,7FFF82F61438
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D75D10]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F50BF8
+       mov       rdx,7FFF82F61488
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827BC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F50C18
+       mov       rdx,7FFF82F614A8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F50B68
+       mov       rdx,7FFF82F613F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8296CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F50AF8
+       mov       rdx,7FFF82F61388
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82806C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8281C600]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF826EF3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827266E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M02_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,23FA6479CB0
-       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82E77D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r14,r14
-       je        short M02_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF82390898
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823908A0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M02_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF82380E10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M02_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M02_L10:
-       mov       rcx,r14
-       mov       r11,7FFF82380E18
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,1FF18401F98
+       mov       r8,152CC401FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8296C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8296CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
        je        short M01_L06
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D761A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C9D8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F50C30
+       mov       rdx,7FFF82F61008
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F50B68
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FFF82F50BA8
+       mov       rdx,7FFF82F60F80
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D75D10]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E0C540]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F50BF8
+       mov       rdx,7FFF82F60FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r13
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827BC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       esi,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F50C18
+       mov       rdx,7FFF82F60FF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F50B68
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF8296CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F50AF8
+       mov       rdx,7FFF82F60ED0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82806C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF826EF3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827266E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M02_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
+       cmp       [rbx],rcx
+       je        short M02_L01
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
+M02_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
+M02_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,23FA6479CB0
-       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82E77D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M02_L00:
-       test      r14,r14
-       je        short M02_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L04
-       jmp       short M02_L02
-M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L00
 M02_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF82390890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M02_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF82380E10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M02_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M02_L10:
-       mov       rcx,r14
-       mov       r11,7FFF82380E18
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,1FF18401F98
+       mov       r8,23CD9801FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8296C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8296CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
-       je        near ptr M01_L07
+       je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FFF824C4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
-       mov       r15,rax
-       test      r15,r15
-       je        near ptr M01_L08
+       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       mov       rdi,rax
+       test      rdi,rdi
+       je        near ptr M01_L09
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
-       je        short M01_L06
+       je        near ptr M01_L07
 M01_L02:
-       mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
-       je        near ptr M01_L08
+       mov       rcx,rdi
+       mov       r15,[rcx]
+       cmp       r15,rax
+       je        near ptr M01_L09
        mov       rcx,[rbx+10]
-       cmp       rcx,[r15+10]
+       cmp       rcx,[rdi+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
-       cmp       r13,rcx
+       cmp       r15,rcx
        je        short M01_L04
-       mov       rcx,r15
+       mov       rcx,rdi
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15+48]
        call      qword ptr [rax+10]
 M01_L04:
-       mov       ecx,[r15+20]
+       mov       ecx,[rdi+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
-       mov       rcx,[r15+8]
+       mov       rcx,[rdi+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82D761A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rcx,r14
-       mov       rdx,7FFF82F50C30
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp       near ptr M01_L02
-M01_L07:
-       mov       rdx,7FFF82F50B68
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
+M01_L07:
+       mov       rcx,r14
+       mov       rdx,7FFF82F62368
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp       near ptr M01_L02
 M01_L08:
+       test      eax,eax
+       jne       near ptr M01_L03
+M01_L09:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       jne       short M01_L12
+       je        short M01_L10
+       jmp       short M01_L11
+M01_L10:
        mov       rcx,r14
-       mov       rdx,7FFF82F50BA8
+       mov       rdx,7FFF82F622E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L09:
+M01_L11:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82D75D10]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       rsi,rax
        cmp       dword ptr [rsp+30],0
-       jg        short M01_L11
-M01_L10:
-       add       rsp,40
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r13
-       pop       r14
-       pop       r15
-       ret
-M01_L11:
+       jle       near ptr M01_L21
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
-       je        short M01_L13
-       jmp       short M01_L14
+       je        short M01_L12
+       jmp       short M01_L13
 M01_L12:
-       jmp       short M01_L09
-M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F50BF8
+       mov       rdx,7FFF82F62330
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L14:
+M01_L13:
        mov       [rsp+20],rdi
-       mov       rdx,r13
+       mov       rdx,rsi
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827BC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC7F8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       mov       ebp,1
        mov       r15d,1
-       mov       esi,1
-       jmp       near ptr M01_L19
-M01_L15:
+       jmp       near ptr M01_L18
+M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
-       je        short M01_L16
-       jmp       short M01_L17
-M01_L16:
+       je        short M01_L15
+       jmp       short M01_L16
+M01_L15:
        mov       rcx,r14
-       mov       rdx,7FFF82F50C18
+       mov       rdx,7FFF82F62350
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
-M01_L17:
-       cmp       esi,[r13+8]
+M01_L16:
+       cmp       r15d,[rsi+8]
        jae       near ptr M01_L27
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r15d
+       mov       rdx,[rsi+rdx*8+10]
+       lea       r8d,[r15-1]
+       cmp       r8d,[rsi+8]
        jae       near ptr M01_L27
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r15-1]
+       mov       r8,[rsi+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
-       je        short M01_L18
-       lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
-       jae       near ptr M01_L27
+       je        short M01_L17
+       lea       ecx,[rbp+1]
+       mov       r13d,ecx
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       mov       rdx,[rsi+rcx*8+10]
+       cmp       ebp,[rsi+8]
+       jae       near ptr M01_L27
+       mov       ecx,ebp
+       lea       rcx,[rsi+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       ebp,r13d
+M01_L17:
+       inc       r15d
 M01_L18:
-       inc       esi
-M01_L19:
-       cmp       esi,[rsp+30]
-       jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       cmp       r15d,[rsp+30]
+       jl        near ptr M01_L14
+       mov       [rsp+30],ebp
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
-       je        short M01_L20
-       jmp       short M01_L21
-M01_L20:
+       je        short M01_L19
+       jmp       short M01_L20
+M01_L19:
        mov       rcx,r14
-       mov       rdx,7FFF82F50B68
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L21:
+M01_L20:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,rsi
        xor       r8d,r8d
-       call      qword ptr [7FFF8296CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
-       jmp       near ptr M01_L10
+M01_L21:
+       add       rsp,40
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
+       ret
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F50AF8
+       mov       rdx,7FFF82F62230
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82806C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8282C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FFF826EF3A8
+       mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FFF827266E8]
+       call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
-       mov       rdx,[r15+10]
+       mov       rdx,[rdi+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
-       test      eax,eax
-       je        near ptr M01_L08
-       jmp       near ptr M01_L03
+       jmp       near ptr M01_L08
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 827
+; Total bytes of code 830
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M02_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M02_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,23FA6479CB0
-       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82E77D68]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M02_L01
 M02_L00:
-       test      r14,r14
-       je        short M02_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L04
-       jmp       short M02_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908A8
+       call      qword ptr [r11]
+       mov       rdi,rax
 M02_L01:
-       add       ebp,1
-       jo        short M02_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M02_L07
+M02_L03:
+       cmp       rbx,rbp
+       jne       short M02_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M02_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M02_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M02_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M02_L02
+M02_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823908B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M02_L01
+       jne       short M02_L02
        jmp       short M02_L06
-M02_L03:
-       add       ebp,1
-       jo        short M02_L07
-M02_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M02_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E77D98]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M02_L05:
-       test      eax,eax
-       jne       short M02_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M02_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M02_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M02_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF82380E10
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M02_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M02_L10:
-       mov       rcx,r14
-       mov       r11,7FFF82380E18
-       call      qword ptr [r11]
-       jmp       short M02_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,150FE001FC0
+       mov       r8,152CC401FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
        cmp       r13,rcx
        je        short M01_L04
        mov       rcx,r15
        mov       edx,1
        mov       rax,[r13+48]
        call      qword ptr [rax+10]
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C9D8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
        mov       rcx,r14
-       mov       rdx,7FFF82F614C0
+       mov       rdx,7FFF82F61008
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L07:
-       mov       rdx,7FFF82F613F8
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FFF82F61438
+       mov       rdx,7FFF82F60F80
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FFF82E0C540]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r13,rax
        cmp       dword ptr [rsp+30],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F61488
+       mov       rdx,7FFF82F60FD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FFF82F614A8
+       mov       rdx,7FFF82F60FF0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       esi,[rsp+30]
        jl        near ptr M01_L15
        mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FFF82F613F8
+       mov       rdx,7FFF82F60F40
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
        mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F61388
+       mov       rdx,7FFF82F60ED0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF8281C600]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       rcx,[rbx+10]
        mov       rdx,[r15+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
        test      eax,eax
        je        near ptr M01_L08
        jmp       near ptr M01_L03
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 827
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       esi,esi
-       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       short M02_L00
+       je        short M02_L01
+       mov       rcx,rbx
+       mov       r11,7FFF82390888
+       call      qword ptr [r11]
+       mov       rdi,rax
+M02_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
+M02_L01:
        mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
-       jmp       short M02_L01
-M02_L00:
-       mov       rcx,rbx
-       mov       r11,7FFF82390898
-       call      qword ptr [r11]
-       mov       rdi,rax
-M02_L01:
-       mov       rbx,[rdi]
-       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
-       jmp       short M02_L03
+       jmp       short M02_L00
 M02_L02:
        add       esi,1
        jo        near ptr M02_L07
        cmp       rbx,rbp
        jne       short M02_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M02_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M02_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       short M02_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M02_L02
 M02_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823908A0
+       mov       r11,7FFF82390890
        call      qword ptr [r11]
        test      eax,eax
        jne       short M02_L02
        jmp       short M02_L06
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,150FE001FC0
+       mov       r8,23CD9801FC0
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
        call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
-       je        near ptr M01_L07
+       je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
-       mov       r15,rax
-       test      r15,r15
-       je        near ptr M01_L08
+       mov       rdi,rax
+       test      rdi,rdi
+       je        near ptr M01_L09
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
-       je        short M01_L06
+       je        near ptr M01_L07
 M01_L02:
-       mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
-       je        near ptr M01_L08
+       mov       rcx,rdi
+       mov       r15,[rcx]
+       cmp       r15,rax
+       je        near ptr M01_L09
        mov       rcx,[rbx+10]
-       cmp       rcx,[r15+10]
+       cmp       rcx,[rdi+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
-       cmp       r13,rcx
+       cmp       r15,rcx
        je        short M01_L04
-       mov       rcx,r15
+       mov       rcx,rdi
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15+48]
        call      qword ptr [rax+10]
 M01_L04:
-       mov       ecx,[r15+20]
+       mov       ecx,[rdi+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
-       mov       rcx,[r15+8]
+       mov       rcx,[rdi+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
        call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rcx,r14
-       mov       rdx,7FFF82F614C0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp       near ptr M01_L02
-M01_L07:
-       mov       rdx,7FFF82F613F8
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
+M01_L07:
+       mov       rcx,r14
+       mov       rdx,7FFF82F62368
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp       near ptr M01_L02
 M01_L08:
+       test      eax,eax
+       jne       near ptr M01_L03
+M01_L09:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       jne       short M01_L12
+       je        short M01_L10
+       jmp       short M01_L11
+M01_L10:
        mov       rcx,r14
-       mov       rdx,7FFF82F61438
+       mov       rdx,7FFF82F622E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L09:
+M01_L11:
        lea       r8,[rsp+30]
        mov       rdx,rsi
        call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
+       mov       rsi,rax
        cmp       dword ptr [rsp+30],0
-       jg        short M01_L11
-M01_L10:
-       add       rsp,40
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r13
-       pop       r14
-       pop       r15
-       ret
-M01_L11:
+       jle       near ptr M01_L21
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
-       je        short M01_L13
-       jmp       short M01_L14
+       je        short M01_L12
+       jmp       short M01_L13
 M01_L12:
-       jmp       short M01_L09
-M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F61488
+       mov       rdx,7FFF82F62330
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L14:
+M01_L13:
        mov       [rsp+20],rdi
-       mov       rdx,r13
+       mov       rdx,rsi
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC7F8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       mov       ebp,1
        mov       r15d,1
-       mov       esi,1
-       jmp       near ptr M01_L19
-M01_L15:
+       jmp       near ptr M01_L18
+M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
-       je        short M01_L16
-       jmp       short M01_L17
-M01_L16:
+       je        short M01_L15
+       jmp       short M01_L16
+M01_L15:
        mov       rcx,r14
-       mov       rdx,7FFF82F614A8
+       mov       rdx,7FFF82F62350
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
-M01_L17:
-       cmp       esi,[r13+8]
+M01_L16:
+       cmp       r15d,[rsi+8]
        jae       near ptr M01_L27
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r15d
+       mov       rdx,[rsi+rdx*8+10]
+       lea       r8d,[r15-1]
+       cmp       r8d,[rsi+8]
        jae       near ptr M01_L27
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r15-1]
+       mov       r8,[rsi+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
-       je        short M01_L18
-       lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
-       jae       near ptr M01_L27
+       je        short M01_L17
+       lea       ecx,[rbp+1]
+       mov       r13d,ecx
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       mov       rdx,[rsi+rcx*8+10]
+       cmp       ebp,[rsi+8]
+       jae       near ptr M01_L27
+       mov       ecx,ebp
+       lea       rcx,[rsi+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       ebp,r13d
+M01_L17:
+       inc       r15d
 M01_L18:
-       inc       esi
-M01_L19:
-       cmp       esi,[rsp+30]
-       jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       cmp       r15d,[rsp+30]
+       jl        near ptr M01_L14
+       mov       [rsp+30],ebp
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
-       je        short M01_L20
-       jmp       short M01_L21
-M01_L20:
+       je        short M01_L19
+       jmp       short M01_L20
+M01_L19:
        mov       rcx,r14
-       mov       rdx,7FFF82F613F8
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L21:
+M01_L20:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,rsi
        xor       r8d,r8d
        call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
-       jmp       near ptr M01_L10
+M01_L21:
+       add       rsp,40
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
+       ret
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F61388
+       mov       rdx,7FFF82F62230
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF8281C600]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8282C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       ecx,7D7
        mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
-       mov       rdx,[r15+10]
+       mov       rdx,[rdi+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
-       test      eax,eax
-       je        near ptr M01_L08
-       jmp       near ptr M01_L03
+       jmp       near ptr M01_L08
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 827
+; Total bytes of code 830
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       esi,esi
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
        jne       short M02_L00
        mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
        jmp       short M02_L01
 M02_L00:
        mov       rcx,rbx
-       mov       r11,7FFF82390898
+       mov       r11,7FFF823908A8
        call      qword ptr [r11]
        mov       rdi,rax
 M02_L01:
        cmp       rbx,rbp
        jne       short M02_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M02_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M02_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       short M02_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M02_L02
 M02_L04:
        mov       rcx,rdi
-       mov       r11,7FFF823908A0
+       mov       r11,7FFF823908B0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M02_L02
        jmp       short M02_L06
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+180]
-       mov       r8,152CC401FC0
+       mov       r8,23CD9801FC0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FFF8297C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF82977918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       rcx,rsi
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setle     al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 87
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        mov       [rsp+38],rcx
        mov       rbx,rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       rbp,rbx
        mov       rdx,rdi
        test      rdx,rdx
        je        near ptr M01_L22
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        je        near ptr M01_L25
 M01_L00:
        mov       r14,[rbx]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rax,[rdx+68]
        test      rax,rax
-       je        near ptr M01_L07
+       je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
-       mov       r15,rax
-       test      r15,r15
-       je        near ptr M01_L08
+       mov       rdi,rax
+       test      rdi,rdi
+       je        near ptr M01_L09
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+88]
        test      rax,rax
-       je        short M01_L06
+       je        near ptr M01_L07
 M01_L02:
-       mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
-       je        near ptr M01_L08
+       mov       rcx,rdi
+       mov       r15,[rcx]
+       cmp       r15,rax
+       je        near ptr M01_L09
        mov       rcx,[rbx+10]
-       cmp       rcx,[r15+10]
+       cmp       rcx,[rdi+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
-       cmp       r13,rcx
+       cmp       r15,rcx
        je        short M01_L04
-       mov       rcx,r15
+       mov       rcx,rdi
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15+48]
        call      qword ptr [rax+10]
 M01_L04:
-       mov       ecx,[r15+20]
+       mov       ecx,[rdi+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
-       mov       rcx,[r15+8]
+       mov       rcx,[rdi+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF82E0C9D8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FFF82E0C198]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rcx,r14
-       mov       rdx,7FFF82F61008
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       jmp       near ptr M01_L02
-M01_L07:
-       mov       rdx,7FFF82F60F40
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
+M01_L07:
+       mov       rcx,r14
+       mov       rdx,7FFF82F62368
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       jmp       near ptr M01_L02
 M01_L08:
+       test      eax,eax
+       jne       near ptr M01_L03
+M01_L09:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+70]
        test      rcx,rcx
-       jne       short M01_L12
+       je        short M01_L10
+       jmp       short M01_L11
+M01_L10:
        mov       rcx,r14
-       mov       rdx,7FFF82F60F80
+       mov       rdx,7FFF82F622E0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L09:
+M01_L11:
        lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FFF82E0C540]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
+       call      qword ptr [7FFF82E07B40]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       rsi,rax
        cmp       dword ptr [rsp+30],0
-       jg        short M01_L11
-M01_L10:
-       add       rsp,40
-       pop       rbx
-       pop       rbp
-       pop       rsi
-       pop       rdi
-       pop       r13
-       pop       r14
-       pop       r15
-       ret
-M01_L11:
+       jle       near ptr M01_L21
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+78]
        test      rcx,rcx
-       je        short M01_L13
-       jmp       short M01_L14
+       je        short M01_L12
+       jmp       short M01_L13
 M01_L12:
-       jmp       short M01_L09
-M01_L13:
        mov       rcx,r14
-       mov       rdx,7FFF82F60FD0
+       mov       rdx,7FFF82F62330
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L14:
+M01_L13:
        mov       [rsp+20],rdi
-       mov       rdx,r13
+       mov       rdx,rsi
        mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FFF827CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF827CC7F8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       mov       ebp,1
        mov       r15d,1
-       mov       esi,1
-       jmp       near ptr M01_L19
-M01_L15:
+       jmp       near ptr M01_L18
+M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+80]
        test      r11,r11
-       je        short M01_L16
-       jmp       short M01_L17
-M01_L16:
+       je        short M01_L15
+       jmp       short M01_L16
+M01_L15:
        mov       rcx,r14
-       mov       rdx,7FFF82F60FF0
+       mov       rdx,7FFF82F62350
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
-M01_L17:
-       cmp       esi,[r13+8]
+M01_L16:
+       cmp       r15d,[rsi+8]
        jae       near ptr M01_L27
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r15d
+       mov       rdx,[rsi+rdx*8+10]
+       lea       r8d,[r15-1]
+       cmp       r8d,[rsi+8]
        jae       near ptr M01_L27
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r15-1]
+       mov       r8,[rsi+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
-       je        short M01_L18
-       lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
-       jae       near ptr M01_L27
+       je        short M01_L17
+       lea       ecx,[rbp+1]
+       mov       r13d,ecx
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       mov       rdx,[rsi+rcx*8+10]
+       cmp       ebp,[rsi+8]
+       jae       near ptr M01_L27
+       mov       ecx,ebp
+       lea       rcx,[rsi+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       ebp,r13d
+M01_L17:
+       inc       r15d
 M01_L18:
-       inc       esi
-M01_L19:
-       cmp       esi,[rsp+30]
-       jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       cmp       r15d,[rsp+30]
+       jl        near ptr M01_L14
+       mov       [rsp+30],ebp
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
-       je        short M01_L20
-       jmp       short M01_L21
-M01_L20:
+       je        short M01_L19
+       jmp       short M01_L20
+M01_L19:
        mov       rcx,r14
-       mov       rdx,7FFF82F60F40
+       mov       rdx,7FFF82F622A0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
-M01_L21:
+M01_L20:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,rsi
        xor       r8d,r8d
-       call      qword ptr [7FFF8297CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FFF82977CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+30]
        mov       [rbx+20],eax
-       jmp       near ptr M01_L10
+M01_L21:
+       add       rsp,40
+       pop       rbx
+       pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r13
+       pop       r14
+       pop       r15
+       ret
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+60]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FFF82F60ED0
+       mov       rdx,7FFF82F62230
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FFF82816C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF8282C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
        mov       ecx,7D7
        mov       rdx,7FFF826FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
        call      qword ptr [7FFF827366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
-       mov       rdx,[r15+10]
+       mov       rdx,[rdi+10]
        mov       rax,[rcx]
        mov       rax,[rax+40]
        call      qword ptr [rax+10]
-       test      eax,eax
-       je        near ptr M01_L08
-       jmp       near ptr M01_L03
+       jmp       near ptr M01_L08
 M01_L27:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 827
+; Total bytes of code 830
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M02_L08
        xor       esi,esi
-       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       je        short M02_L01
-       mov       rcx,rbx
-       mov       r11,7FFF82390888
-       call      qword ptr [r11]
-       mov       rdi,rax
-M02_L00:
-       mov       rbx,[rdi]
-       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
-       jmp       short M02_L03
-M02_L01:
+       jne       short M02_L00
        mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
-       jmp       short M02_L00
+       jmp       short M02_L01
+M02_L00:
+       mov       rcx,rbx
+       mov       r11,7FFF823908A8
+       call      qword ptr [r11]
+       mov       rdi,rax
+M02_L01:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M02_L03
 M02_L02:
        add       esi,1
        jo        near ptr M02_L07
        cmp       rbx,rbp
        jne       short M02_L04
        lea       r14,[rdi+8]
        mov       rcx,[r14]
        mov       [rsp+28],rcx
        mov       edx,[r14+14]
        cmp       edx,[rcx+14]
        jne       short M02_L09
        mov       edx,[r14+10]
        cmp       edx,[rcx+10]
        jae       short M02_L05
        lea       rcx,[r14+8]
        mov       rax,[rsp+28]
        mov       rax,[rax+8]
        cmp       edx,[rax+8]
        jae       short M02_L10
        mov       edx,edx
        mov       rdx,[rax+rdx*8+10]
        call      CORINFO_HELP_CHECKED_ASSIGN_REF
        inc       dword ptr [r14+10]
        jmp       short M02_L02
 M02_L04:
        mov       rcx,rdi
-       mov       r11,7FFF82390890
+       mov       r11,7FFF823908B0
        call      qword ptr [r11]
        test      eax,eax
        jne       short M02_L02
        jmp       short M02_L06
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M01_L10
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,r14
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       [rsp+28],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+40],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       ebx,ebx
        lzcnt     ebx,ecx
        xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        add       ebx,ebx
        js        near ptr M01_L09
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rsp+30],rsi
        xor       ecx,ecx
        mov       [rsp+38],rcx
        mov       byte ptr [rsp+44],0
        lea       rcx,[rsp+28]
        mov       rdx,r14
-       call      qword ptr [7FFF82DA6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82D96CD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r15+8]
        lea       rsi,[rsp+28]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
        mov       rbx,[r15]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,r14
        jne       short M01_L11
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
        xor       eax,eax
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M01_L09:
        mov       ecx,87B
-       mov       rdx,7FFF8271F3A8
+       mov       rdx,7FFF8270F3A8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       ecx,ebx
-       call      qword ptr [7FFF82DF44C8]
+       call      qword ptr [7FFF82DE4228]
        int       3
 M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823A0D58
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M01_L00
 M01_L11:
        mov       rcx,r15
-       mov       r11,7FFF823B0D60
+       mov       r11,7FFF823A0D60
        call      qword ptr [r11]
        jmp       short M01_L05
 ; Total bytes of code 428
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829ACE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
+       jne       near ptr M01_L09
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,r14
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       [rsp+28],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+40],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,2CC94FE9CB0
+       call      qword ptr [7FFF828E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+30],rdi
        xor       ecx,ecx
        mov       [rsp+38],rcx
        mov       byte ptr [rsp+44],0
        lea       rcx,[rsp+28]
        mov       rdx,r14
-       call      qword ptr [7FFF82DA6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82DB6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r15+8]
        lea       rsi,[rsp+28]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
        mov       rbx,[r15]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,r14
-       jne       short M01_L11
+       jne       short M01_L10
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
        xor       eax,eax
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8271F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DF44C8]
-       int       3
-M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823C0D58
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M01_L00
-M01_L11:
+M01_L10:
        mov       rcx,r15
-       mov       r11,7FFF823B0D60
+       mov       r11,7FFF823C0D60
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 428
+; Total bytes of code 408
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M01_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,237278B9CB0
+       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DA6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82DDDC50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M01_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L04
        jmp       short M01_L02
 M01_L01:
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M01_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
 M01_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8271F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DF44C8]
-       int       3
-M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823B0D68
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823B0D60
+M01_L10:
+       mov       rcx,r14
+       mov       r11,7FFF823B0D70
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       ebx,ebx
        lzcnt     ebx,ecx
        xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        add       ebx,ebx
        js        near ptr M01_L09
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rsi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DA6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82E9C258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M01_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L04
        jmp       short M01_L02
 M01_L01:
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L11
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
 M01_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
        mov       ecx,87B
-       mov       rdx,7FFF8271F3A8
+       mov       rdx,7FFF8270F3A8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       ecx,ebx
-       call      qword ptr [7FFF82DF44C8]
+       call      qword ptr [7FFF82C5C4C8]
        int       3
 M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823B0D58
+       mov       r11,7FFF823A0D30
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823B0D60
+       mov       rcx,r14
+       mov       r11,7FFF823A0D38
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 428
+; Total bytes of code 420
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DA6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L06
+       add       esi,1
+       jo        near ptr M01_L07
 M01_L03:
-       add       ebp,1
-       jo        short M01_L07
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M01_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908E8
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L03
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8271F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DF44C8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823B0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823B0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       je        short M01_L01
+       mov       rcx,rbx
+       mov       r11,7FFF823B08A8
+       call      qword ptr [r11]
+       mov       rdi,rax
+M01_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
+M01_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DA6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L00
+M01_L02:
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
        jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
        jmp       short M01_L02
-M01_L01:
-       add       ebp,1
-       jo        short M01_L07
-M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823B08B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8271F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DF44C8]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823B0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823B0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DA6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B0888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L06
+       add       esi,1
+       jo        near ptr M01_L07
 M01_L03:
-       add       ebp,1
-       jo        short M01_L07
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DA6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M01_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823B0890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L03
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8271F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DF44C8]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823B0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823B0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF829ACE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,48
        xor       eax,eax
        mov       [rsp+28],rax
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
+       jne       near ptr M01_L09
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        mov       rcx,r14
        call      CORINFO_HELP_NEWSFAST
        mov       r15,rax
        mov       [rsp+28],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+40],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,2CC94FE9CB0
+       call      qword ptr [7FFF828E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+30],rdi
        xor       ecx,ecx
        mov       [rsp+38],rcx
        mov       byte ptr [rsp+44],0
        lea       rcx,[rsp+28]
        mov       rdx,r14
-       call      qword ptr [7FFF82D96CD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82DB6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r15+8]
        lea       rsi,[rsp+28]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
        mov       rbx,[r15]
        mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,r14
-       jne       short M01_L11
+       jne       short M01_L10
        mov       rdx,rbx
        lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
        xor       eax,eax
        add       rsp,48
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DE4228]
-       int       3
-M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF823C0D58
        call      qword ptr [r11]
        mov       r15,rax
        jmp       near ptr M01_L00
-M01_L11:
+M01_L10:
        mov       rcx,r15
-       mov       r11,7FFF823A0D60
+       mov       r11,7FFF823C0D60
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 428
+; Total bytes of code 408
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M01_L09
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
+       xor       esi,esi
+       lzcnt     esi,ecx
+       xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
+       mov       rdi,rax
+       add       esi,esi
+       mov       ecx,esi
+       mov       rdx,237278B9CB0
+       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
+       lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D96CD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82DDDC50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M01_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L04
        jmp       short M01_L02
 M01_L01:
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M01_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
 M01_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DE4228]
-       int       3
-M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF823B0D68
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0D60
+M01_L10:
+       mov       rcx,r14
+       mov       r11,7FFF823B0D70
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 428
+; Total bytes of code 400
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       ebx,ebx
        lzcnt     ebx,ecx
        xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        add       ebx,ebx
        js        near ptr M01_L09
        movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
+       mov       [rsp+28],rsi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D96CD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82E9C258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M01_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L04
        jmp       short M01_L02
 M01_L01:
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L11
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
 M01_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
        mov       ecx,87B
        mov       rdx,7FFF8270F3A8
        call      CORINFO_HELP_STRCNS
        mov       rdx,rax
        mov       ecx,ebx
-       call      qword ptr [7FFF82DE4228]
+       call      qword ptr [7FFF82C5C4C8]
        int       3
 M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823A0D58
+       mov       r11,7FFF823A0D30
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M01_L00
 M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0D60
+       mov       rcx,r14
+       mov       r11,7FFF823A0D38
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 428
+; Total bytes of code 420
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D96CD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L06
+       add       esi,1
+       jo        near ptr M01_L07
 M01_L03:
-       add       ebp,1
-       jo        short M01_L07
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M01_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908E8
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L03
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DE4228]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       je        short M01_L01
+       mov       rcx,rbx
+       mov       r11,7FFF823B08A8
+       call      qword ptr [r11]
+       mov       rdi,rax
+M01_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
+M01_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D96CD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L00
+M01_L02:
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
        jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
        jmp       short M01_L02
-M01_L01:
-       add       ebp,1
-       jo        short M01_L07
-M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823B08B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DE4228]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rsi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82D96CD0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B0888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L06
+       add       esi,1
+       jo        near ptr M01_L07
 M01_L03:
-       add       ebp,1
-       jo        short M01_L07
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82D96D00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M01_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823B0890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L03
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82DE4228]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r15
-       mov       r11,7FFF823A0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 428
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829ACE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
        jne       near ptr M01_L09
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
        xor       esi,esi
        lzcnt     esi,ecx
        xor       esi,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        add       esi,esi
        mov       ecx,esi
-       mov       rdx,2CC94FE9CB0
-       call      qword ptr [7FFF828E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
+       mov       rdx,237278B9CB0
+       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
        movsxd    rdx,esi
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rdi
+       mov       [rsp+28],rdi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DB6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82DDDC50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M01_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L04
        jmp       short M01_L02
 M01_L01:
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L10
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
 M01_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
        mov       rcx,rbx
-       mov       r11,7FFF823C0D58
+       mov       r11,7FFF823B0D68
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M01_L00
 M01_L10:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D60
+       mov       rcx,r14
+       mov       r11,7FFF823B0D70
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 408
+; Total bytes of code 400
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829ACE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
+       sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M01_L09
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
+       jne       near ptr M01_L10
+       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
+       mov       r14,rax
+       mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
+       mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
+       xor       ebx,ebx
+       lzcnt     ebx,ecx
+       xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,2CC94FE9CB0
-       call      qword ptr [7FFF828E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
+       mov       rsi,rax
+       add       ebx,ebx
+       js        near ptr M01_L09
+       movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rdi+8]
+       lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rdi
+       mov       [rsp+28],rsi
        xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DB6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
+       mov       [rsp+30],rcx
+       mov       byte ptr [rsp+3C],0
+       lea       rcx,[rsp+20]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       call      qword ptr [7FFF82E9C258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       lea       rdi,[r14+8]
+       lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
 M01_L00:
-       test      r15,r15
+       test      r14,r14
        je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
        jne       short M01_L04
        jmp       short M01_L02
 M01_L01:
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L10
+       mov       rbx,[r14]
+       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       rbx,rdx
+       jne       short M01_L11
        mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       lea       rcx,[r14+8]
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
 M01_L06:
        mov       eax,ebp
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
+       mov       ecx,87B
+       mov       rdx,7FFF8270F3A8
+       call      CORINFO_HELP_STRCNS
+       mov       rdx,rax
+       mov       ecx,ebx
+       call      qword ptr [7FFF82C5C4C8]
+       int       3
+M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823C0D58
+       mov       r11,7FFF823A0D30
        call      qword ptr [r11]
-       mov       r15,rax
+       mov       r14,rax
        jmp       near ptr M01_L00
-M01_L10:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D60
+M01_L11:
+       mov       rcx,r14
+       mov       r11,7FFF823A0D38
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 408
+; Total bytes of code 420
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829ACE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M01_L09
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,2CC94FE9CB0
-       call      qword ptr [7FFF828E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rdi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DB6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L06
+       add       esi,1
+       jo        near ptr M01_L07
 M01_L03:
-       add       ebp,1
-       jo        short M01_L07
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L10
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M01_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823908E8
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L03
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF823C0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 408
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829ACE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M01_L09
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
+       cmp       [rbx],rcx
+       je        short M01_L01
+       mov       rcx,rbx
+       mov       r11,7FFF823B08A8
+       call      qword ptr [r11]
+       mov       rdi,rax
+M01_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
+M01_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,2CC94FE9CB0
-       call      qword ptr [7FFF828E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rdi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DB6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L00
+M01_L02:
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
        jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
        jmp       short M01_L02
-M01_L01:
-       add       ebp,1
-       jo        short M01_L07
-M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823B08B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L10
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF823C0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 408
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF829ACE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
-       push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,48
-       xor       eax,eax
-       mov       [rsp+28],rax
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
-       mov       [rsp+40],rax
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M01_L09
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       mov       rcx,r14
-       call      CORINFO_HELP_NEWSFAST
-       mov       r15,rax
-       mov       [rsp+28],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+40],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,2CC94FE9CB0
-       call      qword ptr [7FFF828E40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+30],rdi
-       xor       ecx,ecx
-       mov       [rsp+38],rcx
-       mov       byte ptr [rsp+44],0
-       lea       rcx,[rsp+28]
-       mov       rdx,r14
-       call      qword ptr [7FFF82DB6F28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r15+8]
-       lea       rsi,[rsp+28]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r15,r15
-       je        short M01_L04
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B0888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-       test      eax,eax
-       jne       short M01_L01
-       jmp       short M01_L06
+       add       esi,1
+       jo        near ptr M01_L07
 M01_L03:
-       add       ebp,1
-       jo        short M01_L07
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
+       lea       rcx,[r14+8]
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
 M01_L04:
-       mov       rbx,[r15]
-       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,r14
-       jne       short M01_L10
-       mov       rdx,rbx
-       lea       rcx,[r15+8]
-       call      qword ptr [7FFF82DB6F58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
-M01_L05:
+       mov       rcx,rdi
+       mov       r11,7FFF823B0890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L03
+       jne       short M01_L02
+       jmp       short M01_L06
+M01_L05:
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,48
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L07:
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,48
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
-       pop       r15
        ret
 M01_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF823C0D58
-       call      qword ptr [r11]
-       mov       r15,rax
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,r15
-       mov       r11,7FFF823C0D60
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 408
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,40
        vxorps    xmm4,xmm4,xmm4
        vmovdqa   xmmword ptr [rsp+20],xmm4
        vmovdqa   xmmword ptr [rsp+30],xmm4
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
        xor       ebp,ebp
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rbx],rcx
-       jne       near ptr M01_L09
+       jne       near ptr M01_L10
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       r14,rax
        mov       [rsp+20],rbx
        mov       ecx,[rbx+24]
        mov       [rsp+38],ecx
        mov       ecx,[rbx+20]
        inc       ecx
        or        ecx,1
-       xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
+       xor       ebx,ebx
+       lzcnt     ebx,ecx
+       xor       ebx,1F
        mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
        call      CORINFO_HELP_NEWSFAST
-       mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,237278B9CB0
-       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
+       mov       rsi,rax
+       add       ebx,ebx
+       js        near ptr M01_L09
+       movsxd    rdx,ebx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
        call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rdi+8]
+       lea       rcx,[rsi+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
+       mov       [rsp+28],rsi
        xor       ecx,ecx
        mov       [rsp+30],rcx
        mov       byte ptr [rsp+3C],0
        lea       rcx,[rsp+20]
        mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82DDDC50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
+       call      qword ptr [7FFF82E9C258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
        lea       rdi,[r14+8]
        lea       rsi,[rsp+20]
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        call      CORINFO_HELP_ASSIGN_BYREF
        movsq
        add       ebp,1
        jo        short M01_L07
 M01_L02:
        mov       rdx,rbx
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
        test      eax,eax
        jne       short M01_L01
        jmp       short M01_L06
        add       ebp,1
        jo        short M01_L07
 M01_L04:
        mov       rbx,[r14]
        mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       rbx,rdx
-       jne       short M01_L10
+       jne       short M01_L11
        mov       rdx,rbx
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
        test      eax,eax
        jne       short M01_L03
        xor       eax,eax
        add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
+       mov       ecx,87B
+       mov       rdx,7FFF8270F3A8
+       call      CORINFO_HELP_STRCNS
+       mov       rdx,rax
+       mov       ecx,ebx
+       call      qword ptr [7FFF82C5C4C8]
+       int       3
+M01_L10:
        mov       rcx,rbx
-       mov       r11,7FFF823B0D68
+       mov       r11,7FFF823A0D30
        call      qword ptr [r11]
        mov       r14,rax
        jmp       near ptr M01_L00
-M01_L10:
+M01_L11:
        mov       rcx,r14
-       mov       r11,7FFF823B0D70
+       mov       r11,7FFF823A0D38
        call      qword ptr [r11]
        jmp       short M01_L05
-; Total bytes of code 400
+; Total bytes of code 420
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M01_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,237278B9CB0
-       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82DDDC50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r14,r14
-       je        short M01_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823908E8
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF823B0D68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8270EFB8]
+       int       3
 M01_L10:
-       mov       rcx,r14
-       mov       r11,7FFF823B0D70
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M01_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
+       cmp       [rbx],rcx
+       je        short M01_L01
+       mov       rcx,rbx
+       mov       r11,7FFF823B08A8
+       call      qword ptr [r11]
+       mov       rdi,rax
+M01_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
+M01_L01:
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,237278B9CB0
-       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82DDDC50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
-M01_L00:
-       test      r14,r14
-       je        short M01_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L04
-       jmp       short M01_L02
-M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L00
 M01_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823B08B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF823B0D68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,r14
-       mov       r11,7FFF823B0D70
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [rbx],rcx
-       jne       near ptr M01_L09
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
        xor       esi,esi
-       lzcnt     esi,ecx
-       xor       esi,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       cmp       [rbx],rcx
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       add       esi,esi
-       mov       ecx,esi
-       mov       rdx,237278B9CB0
-       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
-       movsxd    rdx,esi
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
        lea       rcx,[rdi+8]
-       mov       rdx,rax
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rdi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82DDDC50]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r14,r14
-       je        short M01_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B0888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823B0890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L10
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82DDDC80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       rcx,rbx
-       mov       r11,7FFF823B0D68
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M01_L00
+       call      qword ptr [7FFF8272EFB8]
+       int       3
 M01_L10:
-       mov       rcx,r14
-       mov       r11,7FFF823B0D70
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 400
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rsi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82E9C258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r14,r14
-       je        short M01_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823908E0
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823908E8
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82C5C4C8]
+       call      qword ptr [7FFF8270EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0D30
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r14
-       mov       r11,7FFF823A0D38
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 420
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
-       call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rsi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82E9C258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       je        short M01_L01
+       mov       rcx,rbx
+       mov       r11,7FFF823B08A8
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L00:
-       test      r14,r14
-       je        short M01_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
-M01_L02:
+       mov       rcx,offset MT_System.ArrayEnumerator
+       call      CORINFO_HELP_NEWSFAST
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
        mov       rdx,rbx
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L00
+M01_L02:
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823B08B0
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82C5C4C8]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0D30
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r14
-       mov       r11,7FFF823A0D38
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 420
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8298CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
 ; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       vxorps    xmm4,xmm4,xmm4
-       vmovdqa   xmmword ptr [rsp+20],xmm4
-       vmovdqa   xmmword ptr [rsp+30],xmm4
+       sub       rsp,30
        mov       rbx,rcx
        test      rbx,rbx
        je        near ptr M01_L08
-       xor       ebp,ebp
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       xor       esi,esi
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       jne       near ptr M01_L10
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       jne       short M01_L00
+       mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
-       mov       r14,rax
-       mov       [rsp+20],rbx
-       mov       ecx,[rbx+24]
-       mov       [rsp+38],ecx
-       mov       ecx,[rbx+20]
-       inc       ecx
-       or        ecx,1
-       xor       ebx,ebx
-       lzcnt     ebx,ecx
-       xor       ebx,1F
-       mov       rcx,offset MT_System.Collections.Generic.Stack`1[[System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Collections]]
-       call      CORINFO_HELP_NEWSFAST
-       mov       rsi,rax
-       add       ebx,ebx
-       js        near ptr M01_L09
-       movsxd    rdx,ebx
-       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1+Node[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]][]
-       call      CORINFO_HELP_NEWARR_1_OBJ
-       lea       rcx,[rsi+8]
-       mov       rdx,rax
+       mov       rdi,rax
+       lea       rcx,[rdi+8]
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
-       mov       [rsp+28],rsi
-       xor       ecx,ecx
-       mov       [rsp+30],rcx
-       mov       byte ptr [rsp+3C],0
-       lea       rcx,[rsp+20]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       call      qword ptr [7FFF82E9C258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].Initialize()
-       lea       rdi,[r14+8]
-       lea       rsi,[rsp+20]
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       call      CORINFO_HELP_ASSIGN_BYREF
-       movsq
+       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
+       jmp       short M01_L01
 M01_L00:
-       test      r14,r14
-       je        short M01_L04
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L04
-       jmp       short M01_L02
+       mov       rcx,rbx
+       mov       r11,7FFF823B0888
+       call      qword ptr [r11]
+       mov       rdi,rax
 M01_L01:
-       add       ebp,1
-       jo        short M01_L07
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
-       mov       rdx,rbx
+       add       esi,1
+       jo        near ptr M01_L07
+M01_L03:
+       cmp       rbx,rbp
+       jne       short M01_L04
+       lea       r14,[rdi+8]
+       mov       rcx,[r14]
+       mov       [rsp+28],rcx
+       mov       edx,[r14+14]
+       cmp       edx,[rcx+14]
+       jne       short M01_L09
+       mov       edx,[r14+10]
+       cmp       edx,[rcx+10]
+       jae       short M01_L05
        lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       mov       rax,[rsp+28]
+       mov       rax,[rax+8]
+       cmp       edx,[rax+8]
+       jae       short M01_L10
+       mov       edx,edx
+       mov       rdx,[rax+rdx*8+10]
+       call      CORINFO_HELP_CHECKED_ASSIGN_REF
+       inc       dword ptr [r14+10]
+       jmp       short M01_L02
+M01_L04:
+       mov       rcx,rdi
+       mov       r11,7FFF823B0890
+       call      qword ptr [r11]
        test      eax,eax
-       jne       short M01_L01
+       jne       short M01_L02
        jmp       short M01_L06
-M01_L03:
-       add       ebp,1
-       jo        short M01_L07
-M01_L04:
-       mov       rbx,[r14]
-       mov       rdx,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       rbx,rdx
-       jne       short M01_L11
-       mov       rdx,rbx
-       lea       rcx,[r14+8]
-       call      qword ptr [7FFF82E9C288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L05:
-       test      eax,eax
-       jne       short M01_L03
+       mov       rcx,[r14]
+       mov       ecx,[rcx+10]
+       inc       ecx
+       mov       [r14+10],ecx
+       xor       ecx,ecx
+       mov       [r14+8],rcx
 M01_L06:
-       mov       eax,ebp
-       add       rsp,40
+       mov       eax,esi
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
        call      CORINFO_HELP_OVERFLOW
 M01_L08:
        xor       eax,eax
-       add       rsp,40
+       add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L09:
-       mov       ecx,87B
-       mov       rdx,7FFF8270F3A8
-       call      CORINFO_HELP_STRCNS
-       mov       rdx,rax
-       mov       ecx,ebx
-       call      qword ptr [7FFF82C5C4C8]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
-       mov       rcx,rbx
-       mov       r11,7FFF823A0D30
-       call      qword ptr [r11]
-       mov       r14,rax
-       jmp       near ptr M01_L00
-M01_L11:
-       mov       rcx,r14
-       mov       r11,7FFF823A0D38
-       call      qword ptr [r11]
-       jmp       short M01_L05
-; Total bytes of code 420
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 277
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
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
-       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
        cmp       [rbx],rcx
-       jne       short M01_L00
+       je        short M01_L01
+       mov       rcx,rbx
+       mov       r11,7FFF823B08A8
+       call      qword ptr [r11]
+       mov       rdi,rax
+M01_L00:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
+M01_L01:
        mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
-       jmp       short M01_L01
-M01_L00:
-       mov       rcx,rbx
-       mov       r11,7FFF823908E0
-       call      qword ptr [r11]
-       mov       rdi,rax
-M01_L01:
-       mov       rbx,[rdi]
-       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
-       jmp       short M01_L03
+       jmp       short M01_L00
 M01_L02:
        add       esi,1
        jo        near ptr M01_L07
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
-       mov       r11,7FFF823908E8
+       mov       r11,7FFF823B08B0
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
-       call      qword ptr [7FFF8270EFB8]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rcx,[rbx+180]
        test      rcx,rcx
        je        short M00_L01
-       call      qword ptr [7FFF8297CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFF8299CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        test      eax,eax
        setg      al
        movzx     eax,al
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
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
-       mov       r11,7FFF823908E0
+       mov       r11,7FFF823B0888
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
-       mov       r11,7FFF823908E8
+       mov       r11,7FFF823B0890
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
-       call      qword ptr [7FFF8270EFB8]
+       call      qword ptr [7FFF8272EFB8]
        int       3
 M01_L10:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,20
        pop       rbx
        ret
 M00_L01:
        xor       eax,eax
        jmp       short M00_L00
 ; Total bytes of code 51
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
-       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.City[]
+       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.State[]
        cmp       [rbx],rcx
-       je        short M01_L01
-       mov       rcx,rbx
-       mov       r11,7FFF823B08A8
-       call      qword ptr [r11]
-       mov       rdi,rax
-M01_L00:
-       mov       rbx,[rdi]
-       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
-       jmp       short M01_L03
-M01_L01:
+       jne       short M01_L00
        mov       rcx,offset MT_System.ArrayEnumerator
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
-       jmp       short M01_L00
+       jmp       short M01_L01
+M01_L00:
+       mov       rcx,rbx
+       mov       r11,7FFF823B0888
+       call      qword ptr [r11]
+       mov       rdi,rax
+M01_L01:
+       mov       rbx,[rdi]
+       mov       rbp,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
+       jmp       short M01_L03
 M01_L02:
        add       esi,1
        jo        near ptr M01_L07
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
-       mov       r11,7FFF823B08B0
+       mov       r11,7FFF823B0890
        call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L02
        jmp       short M01_L06
```
