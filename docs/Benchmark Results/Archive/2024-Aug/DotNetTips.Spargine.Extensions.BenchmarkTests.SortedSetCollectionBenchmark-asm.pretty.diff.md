## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark-20240502-032223
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,227D2C0ADC0
+       mov       r8,1978740ADC0
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
-       call      qword ptr [7FF80C6CD080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6C7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,227D2C0ADB8
+       mov       rdx,1978740ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF80BE94210]
-       mov       rcx,227D2C0ADC0
+       mov       rcx,1978740ADC0
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C8F8118
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C8F8118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
        mov       rcx,rax
        mov       r11,7FF80BD50D88
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8BD0
+       mov       rdx,7FF80C8F8040
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,[rbp-38]
+       mov       rcx,rax
        mov       r11,7FF80BD50D90
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
        mov       r11,7FF80BD50D90
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
+; Total bytes of code 603
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,227D2C0ADC0
+       mov       r8,2011F40ADC0
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
-       call      qword ptr [7FF80C6CD080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6D74E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,227D2C0ADB8
+       mov       rdx,2011F40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,227D2C0ADC0
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,2011F40ADC0
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C908400
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C908400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD60D88
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8BD0
+       mov       rdx,7FF80C908328
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD60D90
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD60D90
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,227D2C0ADC0
+       mov       r8,20A1D808DC8
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
-       call      qword ptr [7FF80C6CD080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6ED080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,227D2C0ADB8
+       mov       rdx,20A1D808DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,227D2C0ADC0
+       call      qword ptr [7FF80BEB4210]
+       mov       rcx,20A1D808DC8
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C919210
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C919210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD70D88
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8BD0
+       mov       rdx,7FF80C919138
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C114F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C114F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD70D90
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD70D90
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,227D2C0ADC0
+       mov       r8,223A7C08DC8
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
-       call      qword ptr [7FF80C6CD080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6EEB68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,227D2C0ADB8
+       mov       rdx,223A7C08DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF80BE94210]
-       mov       rcx,227D2C0ADC0
+       mov       rcx,223A7C08DC8
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C90DB38
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C90DB38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD50E90
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8BD0
+       mov       rdx,7FF80C90DA60
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD50E98
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD50E98
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,227D2C0ADC0
+       mov       r8,1E2BCC0ADC0
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
-       call      qword ptr [7FF80C6CD080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C80EE20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,227D2C0ADB8
+       mov       rdx,1E2BCC0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,227D2C0ADC0
+       mov       r8,7FF80C889D58
+       call      qword ptr [7FF80BED4210]
+       mov       rcx,1E2BCC0ADC0
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C962EB8
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C962EB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD911F8
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8BD0
+       mov       rdx,7FF80C962DE0
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD91200
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
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD91200
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,227D2C0ADC0
+       mov       r8,1DAE7408DC8
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
-       call      qword ptr [7FF80C6CD080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFDC8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,227D2C0ADB8
+       mov       rdx,1DAE7408DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,227D2C0ADC0
+       mov       r8,7FF80C86AF88
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,1DAE7408DC8
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C92D948
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C92D948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8BD0
+       mov       rdx,7FF80C92D870
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,227D2C0ADC0
+       mov       r8,2448400ADC0
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
-       call      qword ptr [7FF80C6CD080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFA20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,227D2C0ADB8
+       mov       rdx,2448400ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,227D2C0ADC0
+       mov       r8,7FF80C86AC58
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,2448400ADC0
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C8F8CA8
+       mov       rdx,7FF80C9506D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C74C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8BD0
+       mov       rdx,7FF80C9505F8
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1978740ADC0
+       mov       r8,2011F40ADC0
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
-       call      qword ptr [7FF80C6C7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6D74E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1978740ADB8
+       mov       rdx,2011F40ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,1978740ADC0
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,2011F40ADC0
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C908400
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C908400
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD60D88
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8040
+       mov       rdx,7FF80C908328
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD60D90
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD60D90
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
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1978740ADC0
+       mov       r8,20A1D808DC8
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
-       call      qword ptr [7FF80C6C7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6ED080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1978740ADB8
+       mov       rdx,20A1D808DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,1978740ADC0
+       call      qword ptr [7FF80BEB4210]
+       mov       rcx,20A1D808DC8
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C919210
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C919210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD70D88
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8040
+       mov       rdx,7FF80C919138
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C114F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C114F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD70D90
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD70D90
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
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1978740ADC0
+       mov       r8,223A7C08DC8
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
-       call      qword ptr [7FF80C6C7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6EEB68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1978740ADB8
+       mov       rdx,223A7C08DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF80BE94210]
-       mov       rcx,1978740ADC0
+       mov       rcx,223A7C08DC8
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C90DB38
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C90DB38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD50E90
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8040
+       mov       rdx,7FF80C90DA60
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD50E98
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD50E98
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
        mov       rax,[rdx+38]
        test      rax,rax
        je        short M02_L01
        xor       ecx,ecx
        cmp       dword ptr [rax+8],0
        sete      cl
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1978740ADC0
+       mov       r8,1E2BCC0ADC0
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
-       call      qword ptr [7FF80C6C7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C80EE20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1978740ADB8
+       mov       rdx,1E2BCC0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,1978740ADC0
+       mov       r8,7FF80C889D58
+       call      qword ptr [7FF80BED4210]
+       mov       rcx,1E2BCC0ADC0
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C962EB8
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C962EB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD911F8
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8040
+       mov       rdx,7FF80C962DE0
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD91200
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
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD91200
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1978740ADC0
+       mov       r8,1DAE7408DC8
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
-       call      qword ptr [7FF80C6C7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFDC8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1978740ADB8
+       mov       rdx,1DAE7408DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,1978740ADC0
+       mov       r8,7FF80C86AF88
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,1DAE7408DC8
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C92D948
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C92D948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8040
+       mov       rdx,7FF80C92D870
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1978740ADC0
+       mov       r8,2448400ADC0
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
-       call      qword ptr [7FF80C6C7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFA20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1978740ADB8
+       mov       rdx,2448400ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,1978740ADC0
+       mov       r8,7FF80C86AC58
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,2448400ADC0
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C8F8118
+       mov       rdx,7FF80C9506D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C756FE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C8F8040
+       mov       rdx,7FF80C9505F8
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
-       mov       rcx,rax
-       mov       r11,7FF80BD50D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD50D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2011F40ADC0
+       mov       r8,20A1D808DC8
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
-       call      qword ptr [7FF80C6D74E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6ED080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2011F40ADB8
+       mov       rdx,20A1D808DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BEA4210]
-       mov       rcx,2011F40ADC0
+       call      qword ptr [7FF80BEB4210]
+       mov       rcx,20A1D808DC8
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C919210
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C919210
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD60D88
+       mov       r11,7FF80BD70D88
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C908328
+       mov       rdx,7FF80C919138
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
-       call      qword ptr [7FF80C104F30]
+       call      qword ptr [7FF80C114F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C104F30]
+       call      qword ptr [7FF80C114F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD70D90
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
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD70D90
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2011F40ADC0
+       mov       r8,223A7C08DC8
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
-       call      qword ptr [7FF80C6D74E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6EEB68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2011F40ADB8
+       mov       rdx,223A7C08DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BEA4210]
-       mov       rcx,2011F40ADC0
+       call      qword ptr [7FF80BE94210]
+       mov       rcx,223A7C08DC8
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C90DB38
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C90DB38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD60D88
+       mov       r11,7FF80BD50E90
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C908328
+       mov       rdx,7FF80C90DA60
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
-       call      qword ptr [7FF80C104F30]
+       call      qword ptr [7FF80C0F4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C104F30]
+       call      qword ptr [7FF80C0F4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD50E98
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
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD50E98
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2011F40ADC0
+       mov       r8,1E2BCC0ADC0
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
-       call      qword ptr [7FF80C6D74E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C80EE20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2011F40ADB8
+       mov       rdx,1E2BCC0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BEA4210]
-       mov       rcx,2011F40ADC0
+       mov       r8,7FF80C889D58
+       call      qword ptr [7FF80BED4210]
+       mov       rcx,1E2BCC0ADC0
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C962EB8
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C962EB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD60D88
+       mov       r11,7FF80BD911F8
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C908328
+       mov       rdx,7FF80C962DE0
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
-       call      qword ptr [7FF80C104F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C104F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD91200
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
-       mov       r11,7FF80BD60D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD91200
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2011F40ADC0
+       mov       r8,1DAE7408DC8
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
-       call      qword ptr [7FF80C6D74E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFDC8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2011F40ADB8
+       mov       rdx,1DAE7408DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF80C86AF88
        call      qword ptr [7FF80BEA4210]
-       mov       rcx,2011F40ADC0
+       mov       rcx,1DAE7408DC8
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C92D948
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C92D948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD60D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C908328
+       mov       rdx,7FF80C92D870
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,2011F40ADC0
+       mov       r8,2448400ADC0
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
-       call      qword ptr [7FF80C6D74E0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFA20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,2011F40ADB8
+       mov       rdx,2448400ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF80C86AC58
        call      qword ptr [7FF80BEA4210]
-       mov       rcx,2011F40ADC0
+       mov       rcx,2448400ADC0
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C908400
+       mov       rdx,7FF80C9506D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD60D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C766A60]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C908328
+       mov       rdx,7FF80C9505F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD60D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,20A1D808DC8
+       mov       r8,223A7C08DC8
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
-       call      qword ptr [7FF80C6ED080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C6EEB68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,20A1D808DC0
+       mov       rdx,223A7C08DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BEB4210]
-       mov       rcx,20A1D808DC8
+       call      qword ptr [7FF80BE94210]
+       mov       rcx,223A7C08DC8
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C90DB38
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C90DB38
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD70D88
+       mov       r11,7FF80BD50E90
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C919138
+       mov       rdx,7FF80C90DA60
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
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C0F4F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C0F4F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD70D90
+       mov       r11,7FF80BD50E98
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
-       mov       r11,7FF80BD70D90
+       mov       r11,7FF80BD50E98
        call      qword ptr [r11]
 M01_L22:
        nop
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,20A1D808DC8
+       mov       r8,1E2BCC0ADC0
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
-       call      qword ptr [7FF80C6ED080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C80EE20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,20A1D808DC0
+       mov       rdx,1E2BCC0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BEB4210]
-       mov       rcx,20A1D808DC8
+       mov       r8,7FF80C889D58
+       call      qword ptr [7FF80BED4210]
+       mov       rcx,1E2BCC0ADC0
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C962EB8
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C962EB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD70D88
+       mov       r11,7FF80BD911F8
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C919138
+       mov       rdx,7FF80C962DE0
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
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD70D90
+       mov       r11,7FF80BD91200
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
-       mov       r11,7FF80BD70D90
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD91200
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,20A1D808DC8
+       mov       r8,1DAE7408DC8
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
-       call      qword ptr [7FF80C6ED080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFDC8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,20A1D808DC0
+       mov       rdx,1DAE7408DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BEB4210]
-       mov       rcx,20A1D808DC8
+       mov       r8,7FF80C86AF88
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,1DAE7408DC8
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C92D948
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C92D948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD70D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C919138
+       mov       rdx,7FF80C92D870
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
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD70D90
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD70D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,20A1D808DC8
+       mov       r8,2448400ADC0
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
-       call      qword ptr [7FF80C6ED080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFA20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,20A1D808DC0
+       mov       rdx,2448400ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BEB4210]
-       mov       rcx,20A1D808DC8
+       mov       r8,7FF80C86AC58
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,2448400ADC0
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C919210
+       mov       rdx,7FF80C9506D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD70D88
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C76C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C919138
+       mov       rdx,7FF80C9505F8
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
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C114F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD70D90
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD70D90
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,223A7C08DC8
+       mov       r8,1E2BCC0ADC0
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
-       call      qword ptr [7FF80C6EEB68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C80EE20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,223A7C08DC0
+       mov       rdx,1E2BCC0ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,223A7C08DC8
+       mov       r8,7FF80C889D58
+       call      qword ptr [7FF80BED4210]
+       mov       rcx,1E2BCC0ADC0
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C90DB38
+       mov       rdx,7FF80C962EB8
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
-       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C889D58
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
-       mov       rdx,7FF80C90DB38
+       mov       rdx,7FF80C962EB8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50E90
+       mov       r11,7FF80BD911F8
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
-       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C90DA60
+       mov       rdx,7FF80C962DE0
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C134F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50E98
+       mov       r11,7FF80BD91200
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
-       mov       r11,7FF80BD50E98
+       mov       rcx,[rbp-38]
+       mov       r11,7FF80BD91200
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,223A7C08DC8
+       mov       r8,1DAE7408DC8
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
-       call      qword ptr [7FF80C6EEB68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFDC8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,223A7C08DC0
+       mov       rdx,1DAE7408DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,223A7C08DC8
+       mov       r8,7FF80C86AF88
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,1DAE7408DC8
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C90DB38
+       mov       rdx,7FF80C92D948
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
-       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C90DB38
+       mov       rdx,7FF80C92D948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50E90
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C90DA60
+       mov       rdx,7FF80C92D870
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50E98
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD50E98
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,223A7C08DC8
+       mov       r8,2448400ADC0
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
-       call      qword ptr [7FF80C6EEB68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFA20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,223A7C08DC0
+       mov       rdx,2448400ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF80BE94210]
-       mov       rcx,223A7C08DC8
+       mov       r8,7FF80C86AC58
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,2448400ADC0
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C90DB38
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C90DB38
+       mov       rdx,7FF80C9506D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD50E90
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C76E298]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C90DA60
+       mov       rdx,7FF80C9505F8
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
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C0F4F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD50E98
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD50E98
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1E2BCC0ADC0
+       mov       r8,1DAE7408DC8
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
-       call      qword ptr [7FF80C80EE20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFDC8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1E2BCC0ADB8
+       mov       rdx,1DAE7408DC0
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF80C889D58
-       call      qword ptr [7FF80BED4210]
-       mov       rcx,1E2BCC0ADC0
+       mov       r8,7FF80C86AF88
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,1DAE7408DC8
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
-       mov       rdx,7FF80C889D58
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C962EB8
+       mov       rdx,7FF80C92D948
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
-       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C889D58
+       mov       rdx,7FF80C86AF88
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
-       mov       rdx,7FF80C962EB8
+       mov       rdx,7FF80C92D948
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD911F8
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C962DE0
+       mov       rdx,7FF80C92D870
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
-       call      qword ptr [7FF80C134F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C134F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD91200
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD91200
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1E2BCC0ADC0
+       mov       r8,2448400ADC0
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
-       call      qword ptr [7FF80C80EE20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFA20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1E2BCC0ADB8
+       mov       rdx,2448400ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF80C889D58
-       call      qword ptr [7FF80BED4210]
-       mov       rcx,1E2BCC0ADC0
+       mov       r8,7FF80C86AC58
+       call      qword ptr [7FF80BEA4210]
+       mov       rcx,2448400ADC0
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
-       mov       rdx,7FF80C889D58
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C962EB8
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C889D58
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C962EB8
+       mov       rdx,7FF80C9506D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       short M01_L07
 M01_L09:
        mov       rcx,rax
-       mov       r11,7FF80BD911F8
+       mov       r11,7FF80BD61338
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
-       call      qword ptr [7FF80C88E0E8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C962DE0
+       mov       rdx,7FF80C9505F8
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
-       call      qword ptr [7FF80C134F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L17:
        mov       ecx,0C
-       call      qword ptr [7FF80C134F30]
+       call      qword ptr [7FF80C104F30]
        int       3
 M01_L18:
        mov       rcx,rsp
        mov       rcx,rsp
        call      M01_L21
        jmp       short M01_L20
 M01_L19:
        mov       rcx,[rbp-38]
-       mov       r11,7FF80BD91200
+       mov       r11,7FF80BD61340
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
-       mov       r11,7FF80BD91200
+       mov       r11,7FF80BD61340
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
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+190]
-       mov       r8,1DAE7408DC8
+       mov       r8,2448400ADC0
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
-       call      qword ptr [7FF80C7EFDC8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF80C7EFA20]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,1DAE7408DC0
+       mov       rdx,2448400ADB8
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF80C86AF88
+       mov       r8,7FF80C86AC58
        call      qword ptr [7FF80BEA4210]
-       mov       rcx,1DAE7408DC8
+       mov       rcx,2448400ADC0
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
-       mov       rdx,7FF80C86AF88
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C92D948
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
-       mov       rdx,7FF80C86AF88
+       mov       rdx,7FF80C86AC58
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
-       mov       rdx,7FF80C92D948
+       mov       rdx,7FF80C9506D0
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
-       call      qword ptr [7FF80C86F318]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
+       call      qword ptr [7FF80C86EFE8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
 M01_L12:
        test      eax,eax
        je        short M01_L18
        jmp       near ptr M01_L06
 M01_L13:
        mov       rcx,rsi
-       mov       rdx,7FF80C92D870
+       mov       rdx,7FF80C9505F8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       r11,rax
        jmp       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,145FC001F80
+       mov       r8,1E707001F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C919B50
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9097D8
+       mov       rdx,7FF80C919C18
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FF80C909750
+       mov       rdx,7FF80C919B90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9097A0
+       mov       rdx,7FF80C919BE0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9097C0
+       mov       rdx,7FF80C919C00
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C919B50
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9096A0
+       mov       rdx,7FF80C919AE0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1ECBA0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0DF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C1166E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,145FC001F80
+       mov       r8,226C8C01F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C919CC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9097D8
+       mov       rdx,7FF80C919D90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FF80C909750
+       mov       rdx,7FF80C919D08
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9097A0
+       mov       rdx,7FF80C919D58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9097C0
+       mov       rdx,7FF80C919D78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C919CC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9096A0
+       mov       rdx,7FF80C919C58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1ECBA0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0DF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C1166E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,145FC001F80
+       mov       r8,1EADA801F80
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,38
-       mov       [rsp+30],rcx
+       sub       rsp,40
+       mov       [rsp+38],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
-       je        near ptr M01_L07
+       je        short M01_L07
 M01_L02:
        mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
+       cmp       [rcx],rax
        je        near ptr M01_L08
        mov       rcx,[rbx+10]
        cmp       rcx,[r15+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       r13,rcx
+       cmp       [r15],rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
        call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
 M01_L05:
        nop
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C909C20
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9097D8
+       mov       rdx,7FF80C909CE8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
-       lea       r8,[rsp+28]
+       lea       r8,[rsp+30]
        mov       rdx,rsi
        call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r12,rax
-       cmp       dword ptr [rsp+28],0
+       mov       r13,rax
+       cmp       dword ptr [rsp+30],0
        jg        short M01_L11
 M01_L10:
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FF80C909750
+       mov       rdx,7FF80C909C60
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9097A0
+       mov       rdx,7FF80C909CB0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r12
-       mov       r9d,[rsp+28]
+       mov       rdx,r13
+       mov       r9d,[rsp+30]
        xor       r8d,r8d
        call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
-       mov       r13d,1
+       mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9097C0
+       mov       rdx,7FF80C909CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
-       cmp       r13d,[r12+8]
+       cmp       esi,[r13+8]
        jae       near ptr M01_L28
-       mov       edx,r13d
-       mov       rdx,[r12+rdx*8+10]
-       lea       r8d,[r13-1]
-       cmp       r8d,[r12+8]
+       mov       edx,esi
+       mov       rdx,[r13+rdx*8+10]
+       lea       r8d,[rsi-1]
+       cmp       r8d,[r13+8]
        jae       near ptr M01_L28
-       lea       r8d,[r13-1]
-       mov       r8,[r12+r8*8+10]
+       lea       r8d,[rsi-1]
+       mov       r8,[r13+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L18
        lea       ecx,[r15+1]
-       mov       esi,ecx
-       mov       ecx,r13d
-       mov       rdx,[r12+rcx*8+10]
-       cmp       r15d,[r12+8]
+       mov       ebp,ecx
+       mov       ecx,esi
+       mov       rdx,[r13+rcx*8+10]
+       cmp       r15d,[r13+8]
        jae       near ptr M01_L28
        mov       ecx,r15d
-       lea       rcx,[r12+rcx*8+10]
+       lea       rcx,[r13+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,esi
+       mov       r15d,ebp
 M01_L18:
-       inc       r13d
+       inc       esi
 M01_L19:
-       cmp       r13d,[rsp+28]
+       cmp       esi,[rsp+30]
        jl        near ptr M01_L15
-       mov       [rsp+28],r15d
+       mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C909C20
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9d,[rsp+28]
+       mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r12
+       mov       rdx,r13
        xor       r8d,r8d
        call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       eax,[rsp+28]
+       mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9096A0
+       mov       rdx,7FF80C909BB0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1ECBA0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
        mov       rcx,r15
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15]
+       mov       rax,[rax+48]
        call      qword ptr [rax+10]
        jmp       near ptr M01_L04
 M01_L28:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 848
+; Total bytes of code 830
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,145FC001F80
+       mov       r8,148B2001F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C357918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6F6688]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9097D8
+       mov       rdx,7FF80C91C830
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C91C7A8
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C6F61F0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909750
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9097A0
+       mov       rdx,7FF80C91C7F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1ACE58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9097C0
+       mov       rdx,7FF80C91C818
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C357CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9096A0
+       mov       rdx,7FF80C91C6F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1ECBA0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C20C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0DF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C1166E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,145FC001F80
+       mov       r8,20318C01F90
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DE610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9097D8
+       mov       rdx,7FF80C938A90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C938A08
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DE178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909750
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9097A0
+       mov       rdx,7FF80C938A58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9097C0
+       mov       rdx,7FF80C938A78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9096A0
+       mov       rdx,7FF80C938958
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1ECBA0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,145FC001F80
+       mov       r8,1F6B6001FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C37C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BED4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C81E610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9097D8
+       mov       rdx,7FF80C9908E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C990860
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C81E178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909750
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9097A0
+       mov       rdx,7FF80C9908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9097C0
+       mov       rdx,7FF80C9908D0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C37CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9096A0
+       mov       rdx,7FF80C9907B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1ECBA0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C216C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C1366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,145FC001F80
+       mov       r8,1F19B401FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C337918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DDA10]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9097D8
+       mov       rdx,7FF80C9411B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C941128
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DD578]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909750
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9097A0
+       mov       rdx,7FF80C941178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C18C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9097C0
+       mov       rdx,7FF80C941198
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909710
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C337CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9096A0
+       mov       rdx,7FF80C941078
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1ECBA0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1DC690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0BF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C0F66E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1E707001F80
+       mov       r8,226C8C01F80
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C919CC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919C18
+       mov       rdx,7FF80C919D90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FF80C919B90
+       mov       rdx,7FF80C919D08
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919BE0
+       mov       rdx,7FF80C919D58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919C00
+       mov       rdx,7FF80C919D78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C919CC8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919AE0
+       mov       rdx,7FF80C919C58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1E707001F80
+       mov       r8,1EADA801F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,38
-       mov       [rsp+30],rcx
+       sub       rsp,40
+       mov       [rsp+38],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
-       je        near ptr M01_L07
+       je        short M01_L07
 M01_L02:
        mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
+       cmp       [rcx],rax
        je        near ptr M01_L08
        mov       rcx,[rbx+10]
        cmp       rcx,[r15+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       r13,rcx
+       cmp       [r15],rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
 M01_L05:
        nop
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C909C20
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919C18
+       mov       rdx,7FF80C909CE8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
-       lea       r8,[rsp+28]
+       lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r12,rax
-       cmp       dword ptr [rsp+28],0
+       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       r13,rax
+       cmp       dword ptr [rsp+30],0
        jg        short M01_L11
 M01_L10:
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FF80C919B90
+       mov       rdx,7FF80C909C60
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919BE0
+       mov       rdx,7FF80C909CB0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r12
-       mov       r9d,[rsp+28]
+       mov       rdx,r13
+       mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
-       mov       r13d,1
+       mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919C00
+       mov       rdx,7FF80C909CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
-       cmp       r13d,[r12+8]
+       cmp       esi,[r13+8]
        jae       near ptr M01_L28
-       mov       edx,r13d
-       mov       rdx,[r12+rdx*8+10]
-       lea       r8d,[r13-1]
-       cmp       r8d,[r12+8]
+       mov       edx,esi
+       mov       rdx,[r13+rdx*8+10]
+       lea       r8d,[rsi-1]
+       cmp       r8d,[r13+8]
        jae       near ptr M01_L28
-       lea       r8d,[r13-1]
-       mov       r8,[r12+r8*8+10]
+       lea       r8d,[rsi-1]
+       mov       r8,[r13+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L18
        lea       ecx,[r15+1]
-       mov       esi,ecx
-       mov       ecx,r13d
-       mov       rdx,[r12+rcx*8+10]
-       cmp       r15d,[r12+8]
+       mov       ebp,ecx
+       mov       ecx,esi
+       mov       rdx,[r13+rcx*8+10]
+       cmp       r15d,[r13+8]
        jae       near ptr M01_L28
        mov       ecx,r15d
-       lea       rcx,[r12+rcx*8+10]
+       lea       rcx,[r13+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,esi
+       mov       r15d,ebp
 M01_L18:
-       inc       r13d
+       inc       esi
 M01_L19:
-       cmp       r13d,[rsp+28]
+       cmp       esi,[rsp+30]
        jl        near ptr M01_L15
-       mov       [rsp+28],r15d
+       mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C909C20
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9d,[rsp+28]
+       mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r12
+       mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       eax,[rsp+28]
+       mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919AE0
+       mov       rdx,7FF80C909BB0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0CF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1066E8]
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
        mov       rcx,r15
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15]
+       mov       rax,[rax+48]
        call      qword ptr [rax+10]
        jmp       near ptr M01_L04
 M01_L28:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 848
+; Total bytes of code 830
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1E707001F80
+       mov       r8,148B2001F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C357918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6F6688]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919C18
+       mov       rdx,7FF80C91C830
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C91C7A8
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C6F61F0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919B90
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919BE0
+       mov       rdx,7FF80C91C7F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1ACE58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919C00
+       mov       rdx,7FF80C91C818
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C357CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919AE0
+       mov       rdx,7FF80C91C6F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C20C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1E707001F80
+       mov       r8,20318C01F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DE610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919C18
+       mov       rdx,7FF80C938A90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C938A08
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DE178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919B90
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919BE0
+       mov       rdx,7FF80C938A58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919C00
+       mov       rdx,7FF80C938A78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919AE0
+       mov       rdx,7FF80C938958
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0CF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1066E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1E707001F80
+       mov       r8,1F6B6001FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C37C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BED4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C81E610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919C18
+       mov       rdx,7FF80C9908E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C990860
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C81E178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919B90
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919BE0
+       mov       rdx,7FF80C9908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919C00
+       mov       rdx,7FF80C9908D0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C37CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919AE0
+       mov       rdx,7FF80C9907B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C216C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1E707001F80
+       mov       r8,1F19B401FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C337918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DDA10]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919C18
+       mov       rdx,7FF80C9411B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C941128
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DD578]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919B90
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919BE0
+       mov       rdx,7FF80C941178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C18C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919C00
+       mov       rdx,7FF80C941198
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919B50
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C337CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919AE0
+       mov       rdx,7FF80C941078
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1DC690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0BF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C0F66E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,226C8C01F80
+       mov       r8,1EADA801F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,38
-       mov       [rsp+30],rcx
+       sub       rsp,40
+       mov       [rsp+38],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
-       je        near ptr M01_L07
+       je        short M01_L07
 M01_L02:
        mov       rcx,r15
-       mov       r13,[rcx]
-       cmp       r13,rax
+       cmp       [rcx],rax
        je        near ptr M01_L08
        mov       rcx,[rbx+10]
        cmp       rcx,[r15+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       r13,rcx
+       cmp       [r15],rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
 M01_L05:
        nop
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C909C20
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919D90
+       mov       rdx,7FF80C909CE8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        je        short M01_L12
 M01_L09:
-       lea       r8,[rsp+28]
+       lea       r8,[rsp+30]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r12,rax
-       cmp       dword ptr [rsp+28],0
+       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       r13,rax
+       cmp       dword ptr [rsp+30],0
        jg        short M01_L11
 M01_L10:
-       add       rsp,38
+       add       rsp,40
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
        mov       rcx,r14
-       mov       rdx,7FF80C919D08
+       mov       rdx,7FF80C909C60
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919D58
+       mov       rdx,7FF80C909CB0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r12
-       mov       r9d,[rsp+28]
+       mov       rdx,r13
+       mov       r9d,[rsp+30]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
-       mov       r13d,1
+       mov       esi,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919D78
+       mov       rdx,7FF80C909CD0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
-       cmp       r13d,[r12+8]
+       cmp       esi,[r13+8]
        jae       near ptr M01_L28
-       mov       edx,r13d
-       mov       rdx,[r12+rdx*8+10]
-       lea       r8d,[r13-1]
-       cmp       r8d,[r12+8]
+       mov       edx,esi
+       mov       rdx,[r13+rdx*8+10]
+       lea       r8d,[rsi-1]
+       cmp       r8d,[r13+8]
        jae       near ptr M01_L28
-       lea       r8d,[r13-1]
-       mov       r8,[r12+r8*8+10]
+       lea       r8d,[rsi-1]
+       mov       r8,[r13+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L18
        lea       ecx,[r15+1]
-       mov       esi,ecx
-       mov       ecx,r13d
-       mov       rdx,[r12+rcx*8+10]
-       cmp       r15d,[r12+8]
+       mov       ebp,ecx
+       mov       ecx,esi
+       mov       rdx,[r13+rcx*8+10]
+       cmp       r15d,[r13+8]
        jae       near ptr M01_L28
        mov       ecx,r15d
-       lea       rcx,[r12+rcx*8+10]
+       lea       rcx,[r13+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,esi
+       mov       r15d,ebp
 M01_L18:
-       inc       r13d
+       inc       esi
 M01_L19:
-       cmp       r13d,[rsp+28]
+       cmp       esi,[rsp+30]
        jl        near ptr M01_L15
-       mov       [rsp+28],r15d
+       mov       [rsp+30],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C909C20
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9d,[rsp+28]
+       mov       r9d,[rsp+30]
        dec       r9d
-       mov       rdx,r12
+       mov       rdx,r13
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       eax,[rsp+28]
+       mov       eax,[rsp+30]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919C58
+       mov       rdx,7FF80C909BB0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0CF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1066E8]
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
        mov       rcx,r15
        mov       edx,1
-       mov       rax,[r13+48]
+       mov       rax,[r15]
+       mov       rax,[rax+48]
        call      qword ptr [rax+10]
        jmp       near ptr M01_L04
 M01_L28:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 848
+; Total bytes of code 830
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,226C8C01F80
+       mov       r8,148B2001F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C357918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6F6688]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919D90
+       mov       rdx,7FF80C91C830
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C91C7A8
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C6F61F0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919D08
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919D58
+       mov       rdx,7FF80C91C7F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1ACE58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919D78
+       mov       rdx,7FF80C91C818
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C357CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919C58
+       mov       rdx,7FF80C91C6F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C20C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,226C8C01F80
+       mov       r8,20318C01F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DE610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919D90
+       mov       rdx,7FF80C938A90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C938A08
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DE178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919D08
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919D58
+       mov       rdx,7FF80C938A58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919D78
+       mov       rdx,7FF80C938A78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919C58
+       mov       rdx,7FF80C938958
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0CF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1066E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,226C8C01F80
+       mov       r8,1F6B6001FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C37C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BED4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C81E610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919D90
+       mov       rdx,7FF80C9908E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C990860
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C81E178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919D08
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919D58
+       mov       rdx,7FF80C9908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919D78
+       mov       rdx,7FF80C9908D0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C37CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919C58
+       mov       rdx,7FF80C9907B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C216C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,226C8C01F80
+       mov       r8,1F19B401FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C35C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C337918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6E7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DDA10]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C919D90
+       mov       rdx,7FF80C9411B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C941128
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6E77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DD578]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C919D08
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C919D58
+       mov       rdx,7FF80C941178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1AC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C18C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C919D78
+       mov       rdx,7FF80C941198
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C919CC8
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C35CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C337CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C919C58
+       mov       rdx,7FF80C941078
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1F6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1DC690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0BF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C0F66E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1EADA801F80
+       mov       r8,148B2001F80
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C357918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
+       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       mov       [rsp+38],rcx
+       sub       rsp,38
+       mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
-       je        short M01_L07
+       je        near ptr M01_L07
 M01_L02:
        mov       rcx,r15
-       cmp       [rcx],rax
+       mov       r13,[rcx]
+       cmp       r13,rax
        je        near ptr M01_L08
        mov       rcx,[rbx+10]
        cmp       rcx,[r15+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [r15],rcx
+       cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C6F6688]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
 M01_L05:
        nop
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C909CE8
+       mov       rdx,7FF80C91C830
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C91C7A8
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
-       lea       r8,[rsp+30]
+       lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
-       cmp       dword ptr [rsp+30],0
+       call      qword ptr [7FF80C6F61F0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       r12,rax
+       cmp       dword ptr [rsp+28],0
        jg        short M01_L11
 M01_L10:
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909C60
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C909CB0
+       mov       rdx,7FF80C91C7F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r13
-       mov       r9d,[rsp+30]
+       mov       rdx,r12
+       mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1ACE58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
-       mov       esi,1
+       mov       r13d,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C909CD0
+       mov       rdx,7FF80C91C818
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
-       cmp       esi,[r13+8]
+       cmp       r13d,[r12+8]
        jae       near ptr M01_L28
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r13d
+       mov       rdx,[r12+rdx*8+10]
+       lea       r8d,[r13-1]
+       cmp       r8d,[r12+8]
        jae       near ptr M01_L28
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r13-1]
+       mov       r8,[r12+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L18
        lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
+       mov       esi,ecx
+       mov       ecx,r13d
+       mov       rdx,[r12+rcx*8+10]
+       cmp       r15d,[r12+8]
        jae       near ptr M01_L28
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       lea       rcx,[r12+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       r15d,esi
 M01_L18:
-       inc       esi
+       inc       r13d
 M01_L19:
-       cmp       esi,[rsp+30]
+       cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C91C768
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9d,[rsp+30]
+       mov       r9d,[rsp+28]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C357CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       eax,[rsp+30]
+       mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C909BB0
+       mov       rdx,7FF80C91C6F8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C20C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0DF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C1166E8]
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
        mov       rcx,r15
        mov       edx,1
-       mov       rax,[r15]
-       mov       rax,[rax+48]
+       mov       rax,[r13+48]
        call      qword ptr [rax+10]
        jmp       near ptr M01_L04
 M01_L28:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 830
+; Total bytes of code 848
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1EADA801F80
+       mov       r8,20318C01F90
        mov       r8,[r8]
        mov       rcx,rsi
        call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
+       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       mov       [rsp+38],rcx
+       sub       rsp,38
+       mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
        call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
-       je        short M01_L07
+       je        near ptr M01_L07
 M01_L02:
        mov       rcx,r15
-       cmp       [rcx],rax
+       mov       r13,[rcx]
+       cmp       r13,rax
        je        near ptr M01_L08
        mov       rcx,[rbx+10]
        cmp       rcx,[r15+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [r15],rcx
+       cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DE610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
 M01_L05:
        nop
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C909CE8
+       mov       rdx,7FF80C938A90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C938A08
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
-       lea       r8,[rsp+30]
+       lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
-       cmp       dword ptr [rsp+30],0
+       call      qword ptr [7FF80C7DE178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       r12,rax
+       cmp       dword ptr [rsp+28],0
        jg        short M01_L11
 M01_L10:
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909C60
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C909CB0
+       mov       rdx,7FF80C938A58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r13
-       mov       r9d,[rsp+30]
+       mov       rdx,r12
+       mov       r9d,[rsp+28]
        xor       r8d,r8d
        call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
-       mov       esi,1
+       mov       r13d,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C909CD0
+       mov       rdx,7FF80C938A78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
-       cmp       esi,[r13+8]
+       cmp       r13d,[r12+8]
        jae       near ptr M01_L28
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r13d
+       mov       rdx,[r12+rdx*8+10]
+       lea       r8d,[r13-1]
+       cmp       r8d,[r12+8]
        jae       near ptr M01_L28
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r13-1]
+       mov       r8,[r12+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L18
        lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
+       mov       esi,ecx
+       mov       ecx,r13d
+       mov       rdx,[r12+rcx*8+10]
+       cmp       r15d,[r12+8]
        jae       near ptr M01_L28
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       lea       rcx,[r12+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       r15d,esi
 M01_L18:
-       inc       esi
+       inc       r13d
 M01_L19:
-       cmp       esi,[rsp+30]
+       cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9d,[rsp+30]
+       mov       r9d,[rsp+28]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,r12
        xor       r8d,r8d
        call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       eax,[rsp+30]
+       mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C909BB0
+       mov       rdx,7FF80C938958
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
        mov       rcx,r15
        mov       edx,1
-       mov       rax,[r15]
-       mov       rax,[rax+48]
+       mov       rax,[r13+48]
        call      qword ptr [rax+10]
        jmp       near ptr M01_L04
 M01_L28:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 830
+; Total bytes of code 848
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1EADA801F80
+       mov       r8,1F6B6001FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C37C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
+       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       mov       [rsp+38],rcx
+       sub       rsp,38
+       mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BED4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
-       je        short M01_L07
+       je        near ptr M01_L07
 M01_L02:
        mov       rcx,r15
-       cmp       [rcx],rax
+       mov       r13,[rcx]
+       cmp       r13,rax
        je        near ptr M01_L08
        mov       rcx,[rbx+10]
        cmp       rcx,[r15+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [r15],rcx
+       cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C81E610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
 M01_L05:
        nop
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C909CE8
+       mov       rdx,7FF80C9908E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C990860
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
-       lea       r8,[rsp+30]
+       lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
-       cmp       dword ptr [rsp+30],0
+       call      qword ptr [7FF80C81E178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       r12,rax
+       cmp       dword ptr [rsp+28],0
        jg        short M01_L11
 M01_L10:
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909C60
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C909CB0
+       mov       rdx,7FF80C9908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r13
-       mov       r9d,[rsp+30]
+       mov       rdx,r12
+       mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
-       mov       esi,1
+       mov       r13d,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C909CD0
+       mov       rdx,7FF80C9908D0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
-       cmp       esi,[r13+8]
+       cmp       r13d,[r12+8]
        jae       near ptr M01_L28
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r13d
+       mov       rdx,[r12+rdx*8+10]
+       lea       r8d,[r13-1]
+       cmp       r8d,[r12+8]
        jae       near ptr M01_L28
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r13-1]
+       mov       r8,[r12+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L18
        lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
+       mov       esi,ecx
+       mov       ecx,r13d
+       mov       rdx,[r12+rcx*8+10]
+       cmp       r15d,[r12+8]
        jae       near ptr M01_L28
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       lea       rcx,[r12+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       r15d,esi
 M01_L18:
-       inc       esi
+       inc       r13d
 M01_L19:
-       cmp       esi,[rsp+30]
+       cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9d,[rsp+30]
+       mov       r9d,[rsp+28]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C37CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       eax,[rsp+30]
+       mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C909BB0
+       mov       rdx,7FF80C9907B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C216C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C1366E8]
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
        mov       rcx,r15
        mov       edx,1
-       mov       rax,[r15]
-       mov       rax,[rax+48]
+       mov       rax,[r13+48]
        call      qword ptr [rax+10]
        jmp       near ptr M01_L04
 M01_L28:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 830
+; Total bytes of code 848
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1EADA801F80
+       mov       r8,1F19B401FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C337918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
+       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,40
-       mov       [rsp+38],rcx
+       sub       rsp,38
+       mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
-       je        short M01_L07
+       je        near ptr M01_L07
 M01_L02:
        mov       rcx,r15
-       cmp       [rcx],rax
+       mov       r13,[rcx]
+       cmp       r13,rax
        je        near ptr M01_L08
        mov       rcx,[rbx+10]
        cmp       rcx,[r15+10]
        jne       near ptr M01_L26
 M01_L03:
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
-       cmp       [r15],rcx
+       cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6D7C60]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DDA10]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
 M01_L05:
        nop
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C909CE8
+       mov       rdx,7FF80C9411B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
-       je        short M01_L12
+       jne       short M01_L12
+       mov       rcx,r14
+       mov       rdx,7FF80C941128
+       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
+       mov       rcx,rax
 M01_L09:
-       lea       r8,[rsp+30]
+       lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6D77C8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
-       mov       r13,rax
-       cmp       dword ptr [rsp+30],0
+       call      qword ptr [7FF80C7DD578]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       mov       r12,rax
+       cmp       dword ptr [rsp+28],0
        jg        short M01_L11
 M01_L10:
-       add       rsp,40
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
        mov       rdi,[rbx+10]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+68]
        test      rcx,rcx
        je        short M01_L13
        jmp       short M01_L14
 M01_L12:
-       mov       rcx,r14
-       mov       rdx,7FF80C909C60
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       rcx,rax
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C909CB0
+       mov       rdx,7FF80C941178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
-       mov       rdx,r13
-       mov       r9d,[rsp+30]
+       mov       rdx,r12
+       mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C18C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
-       mov       esi,1
+       mov       r13d,1
        jmp       near ptr M01_L19
 M01_L15:
        mov       rcx,[r14+30]
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C909CD0
+       mov       rdx,7FF80C941198
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
-       cmp       esi,[r13+8]
+       cmp       r13d,[r12+8]
        jae       near ptr M01_L28
-       mov       edx,esi
-       mov       rdx,[r13+rdx*8+10]
-       lea       r8d,[rsi-1]
-       cmp       r8d,[r13+8]
+       mov       edx,r13d
+       mov       rdx,[r12+rdx*8+10]
+       lea       r8d,[r13-1]
+       cmp       r8d,[r12+8]
        jae       near ptr M01_L28
-       lea       r8d,[rsi-1]
-       mov       r8,[r13+r8*8+10]
+       lea       r8d,[r13-1]
+       mov       r8,[r12+r8*8+10]
        mov       rcx,rdi
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L18
        lea       ecx,[r15+1]
-       mov       ebp,ecx
-       mov       ecx,esi
-       mov       rdx,[r13+rcx*8+10]
-       cmp       r15d,[r13+8]
+       mov       esi,ecx
+       mov       ecx,r13d
+       mov       rdx,[r12+rcx*8+10]
+       cmp       r15d,[r12+8]
        jae       near ptr M01_L28
        mov       ecx,r15d
-       lea       rcx,[r13+rcx*8+10]
+       lea       rcx,[r12+rcx*8+10]
        call      CORINFO_HELP_ASSIGN_REF
-       mov       r15d,ebp
+       mov       r15d,esi
 M01_L18:
-       inc       esi
+       inc       r13d
 M01_L19:
-       cmp       esi,[rsp+30]
+       cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
-       mov       [rsp+30],r15d
+       mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C909C20
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
-       mov       r9d,[rsp+30]
+       mov       r9d,[rsp+28]
        dec       r9d
-       mov       rdx,r13
+       mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C337CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       eax,[rsp+30]
+       mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
 M01_L22:
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C909BB0
+       mov       rdx,7FF80C941078
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1DC690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0BF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C0F66E8]
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
        mov       rcx,r15
        mov       edx,1
-       mov       rax,[r15]
-       mov       rax,[rax+48]
+       mov       rax,[r13+48]
        call      qword ptr [rax+10]
        jmp       near ptr M01_L04
 M01_L28:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 830
+; Total bytes of code 848
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,148B2001F80
+       mov       r8,20318C01F90
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C357918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6F6688]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DE610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C91C768
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C91C830
+       mov       rdx,7FF80C938A90
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FF80C91C7A8
+       mov       rdx,7FF80C938A08
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6F61F0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DE178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C91C7F8
+       mov       rdx,7FF80C938A58
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1ACE58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C91C818
+       mov       rdx,7FF80C938A78
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C91C768
+       mov       rdx,7FF80C9389C8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C357CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C91C6F8
+       mov       rdx,7FF80C938958
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C20C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0CF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1066E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,148B2001F80
+       mov       r8,1F6B6001FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C357918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C37C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BED4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6F6688]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C81E610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C91C768
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C91C830
+       mov       rdx,7FF80C9908E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FF80C91C7A8
+       mov       rdx,7FF80C990860
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6F61F0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C81E178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C91C7F8
+       mov       rdx,7FF80C9908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1ACE58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C91C818
+       mov       rdx,7FF80C9908D0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C91C768
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C357CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C37CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C91C6F8
+       mov       rdx,7FF80C9907B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C20C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C216C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C1366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,148B2001F80
+       mov       r8,1F19B401FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C357918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C337918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C6F6688]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DDA10]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C91C768
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C91C830
+       mov       rdx,7FF80C9411B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FF80C91C7A8
+       mov       rdx,7FF80C941128
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C6F61F0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DD578]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C91C7F8
+       mov       rdx,7FF80C941178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1ACE58]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C18C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C91C818
+       mov       rdx,7FF80C941198
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C91C768
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C357CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C337CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C91C6F8
+       mov       rdx,7FF80C941078
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C20C510]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1DC690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0DF3A8
+       mov       rdx,7FF80C0BF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1166E8]
+       call      qword ptr [7FF80C0F66E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,20318C01F90
+       mov       r8,1F6B6001FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C37C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BED4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C7DE610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C81E610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C9389C8
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C938A90
+       mov       rdx,7FF80C9908E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FF80C938A08
+       mov       rdx,7FF80C990860
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C7DE178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C81E178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C938A58
+       mov       rdx,7FF80C9908B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C1CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C938A78
+       mov       rdx,7FF80C9908D0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C9389C8
+       mov       rdx,7FF80C990820
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C37CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C938958
+       mov       rdx,7FF80C9907B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C216C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0FF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C1366E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,20318C01F90
+       mov       r8,1F19B401FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C34C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C337918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BEA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C7DE610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DDA10]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C9389C8
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C938A90
+       mov       rdx,7FF80C9411B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FF80C938A08
+       mov       rdx,7FF80C941128
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C7DE178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DD578]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C938A58
+       mov       rdx,7FF80C941178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C19C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C18C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C938A78
+       mov       rdx,7FF80C941198
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C9389C8
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C34CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C337CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C938958
+       mov       rdx,7FF80C941078
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C1E6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1DC690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0CF3A8
+       mov       rdx,7FF80C0BF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1066E8]
+       call      qword ptr [7FF80C0F66E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rdx,[rbx+190]
-       mov       r8,1F6B6001FB0
+       mov       r8,1F19B401FB0
        mov       r8,[r8]
        mov       rcx,rsi
-       call      qword ptr [7FF80C37C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C337918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        xor       eax,eax
        cmp       dword ptr [rsi+20],0
        setle     al
        mov       rcx,[rbx+18]
        mov       [rcx+4C],al
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 79
 ; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
        push      r15
        push      r14
        push      r13
        push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,38
        mov       [rsp+30],rcx
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
        mov       rax,[rdx+58]
        test      rax,rax
        je        near ptr M01_L06
        mov       rcx,rax
 M01_L01:
        mov       rdx,rsi
-       call      qword ptr [7FF80BED4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       call      qword ptr [7FF80BE94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       r15,rax
        test      r15,r15
        je        near ptr M01_L08
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rax,[rcx+78]
        test      rax,rax
        je        near ptr M01_L07
        mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       r13,rcx
        jne       near ptr M01_L27
 M01_L04:
        mov       ecx,[r15+20]
        test      ecx,ecx
        jle       short M01_L05
        mov       [rbx+20],ecx
        mov       rcx,[r15+8]
        mov       edx,[rbx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF80C81E610]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
+       call      qword ptr [7FF80C7DDA10]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        nop
        add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r12
        pop       r13
        pop       r14
        pop       r15
        ret
 M01_L06:
-       mov       rdx,7FF80C990820
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
        jmp       near ptr M01_L01
 M01_L07:
        mov       rcx,r14
-       mov       rdx,7FF80C9908E8
+       mov       rdx,7FF80C9411B0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        jmp       near ptr M01_L02
 M01_L08:
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+60]
        test      rcx,rcx
        jne       short M01_L12
        mov       rcx,r14
-       mov       rdx,7FF80C990860
+       mov       rdx,7FF80C941128
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L09:
        lea       r8,[rsp+28]
        mov       rdx,rsi
-       call      qword ptr [7FF80C81E178]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
+       call      qword ptr [7FF80C7DD578]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
        mov       r12,rax
        cmp       dword ptr [rsp+28],0
        jg        short M01_L11
        jmp       short M01_L09
 M01_L13:
        mov       rcx,r14
-       mov       rdx,7FF80C9908B0
+       mov       rdx,7FF80C941178
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L14:
        mov       [rsp+20],rdi
        mov       rdx,r12
        mov       r9d,[rsp+28]
        xor       r8d,r8d
-       call      qword ptr [7FF80C1CC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FF80C18C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
        mov       r15d,1
        mov       r13d,1
        jmp       near ptr M01_L19
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       r11,[rcx+70]
        test      r11,r11
        je        short M01_L16
        jmp       short M01_L17
 M01_L16:
        mov       rcx,r14
-       mov       rdx,7FF80C9908D0
+       mov       rdx,7FF80C941198
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       r11,rax
 M01_L17:
        cmp       r13d,[rsp+28]
        jl        near ptr M01_L15
        mov       [rsp+28],r15d
        mov       rcx,[r14+30]
        mov       rcx,[rcx]
        mov       rcx,[rcx+58]
        test      rcx,rcx
        je        short M01_L20
        jmp       short M01_L21
 M01_L20:
        mov       rcx,r14
-       mov       rdx,7FF80C990820
+       mov       rdx,7FF80C9410E8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rcx,rax
 M01_L21:
        xor       r9d,r9d
        mov       [rsp+20],r9
        mov       r9d,[rsp+28]
        dec       r9d
        mov       rdx,r12
        xor       r8d,r8d
-       call      qword ptr [7FF80C37CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
+       call      qword ptr [7FF80C337CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
        lea       rcx,[rbx+8]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
        mov       eax,[rsp+28]
        mov       [rbx+20],eax
        jmp       near ptr M01_L10
        mov       r14,[rbp]
        mov       rcx,r14
        mov       rdx,[rcx+30]
        mov       rdx,[rdx]
        mov       rdx,[rdx+50]
        test      rdx,rdx
        je        short M01_L23
        jmp       short M01_L24
 M01_L23:
-       mov       rdx,7FF80C9907B0
+       mov       rdx,7FF80C941078
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       rdx,rax
 M01_L24:
        mov       rcx,rdx
-       call      qword ptr [7FF80C216C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FF80C1DC690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rdx,rax
        lea       rcx,[rbx+10]
        call      CORINFO_HELP_ASSIGN_REF
        test      rsi,rsi
        jne       near ptr M01_L00
 M01_L25:
        mov       ecx,7D7
-       mov       rdx,7FF80C0FF3A8
+       mov       rdx,7FF80C0BF3A8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      qword ptr [7FF80C1366E8]
+       call      qword ptr [7FF80C0F66E8]
        int       3
 M01_L26:
        mov       rcx,[rbx+10]
```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
**Diff for HasItems method between:**
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
.NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```diff

```
