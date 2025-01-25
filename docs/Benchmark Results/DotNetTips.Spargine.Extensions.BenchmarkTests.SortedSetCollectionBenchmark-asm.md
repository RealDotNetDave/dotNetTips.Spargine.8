## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,16AF200D110
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
       call      qword ptr [7FF95D4F4048]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,16AF200D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95CAA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16AF200D110
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
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
       mov       rdx,7FF95D6D76D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-38]
       jne       near ptr M01_L14
M01_L05:
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D52DCB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
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
       mov       rdx,7FF95D6D76D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C961048
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
       call      qword ptr [7FF95D52DCB0]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D6D75F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD34F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD34F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FF95C961050
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
       mov       r11,7FF95C961050
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
; Total bytes of code 607
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
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
       call      qword ptr [7FF95CAA41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,248F440D110
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
       call      qword ptr [7FF95D505860]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,248F440D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95CAB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,248F440D110
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
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
       mov       rdx,7FF95D6E92D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-38]
       jne       near ptr M01_L14
M01_L05:
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D53F258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
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
       mov       rdx,7FF95D6E92D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C971048
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
       call      qword ptr [7FF95D53F258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D6E9200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD44F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD44F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FF95C971050
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
       mov       r11,7FF95C971050
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
; Total bytes of code 603
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
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
       call      qword ptr [7FF95CAB41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,28E5840B118
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
       call      qword ptr [7FF95D504FC0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,28E5840B110
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95CAB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28E5840B118
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
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
       mov       rdx,7FF95D6E9190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L14
M01_L05:
       mov       rax,[rbp-38]
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D54EA00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
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
       mov       rdx,7FF95D6E9190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C971048
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
       call      qword ptr [7FF95D54EA00]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D6E90B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD44F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD44F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FF95C971050
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
       mov       r11,7FF95C971050
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
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
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
       call      qword ptr [7FF95CAB41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1641140B118
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
       call      qword ptr [7FF95D505860]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,1641140B110
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95CAB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1641140B118
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
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
       mov       rdx,7FF95D6E9268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L14
M01_L05:
       mov       rax,[rbp-38]
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D53EF58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
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
       mov       rdx,7FF95D6E9268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C971048
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
       call      qword ptr [7FF95D53EF58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D6E9190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD44F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD44F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FF95C971050
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
       mov       r11,7FF95C971050
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
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
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
       call      qword ptr [7FF95CAB41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,16B0A80D110
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
       call      qword ptr [7FF95D4D5860]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,16B0A80D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95CA84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16B0A80D110
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
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
       mov       rdx,7FF95D6B98A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       mov       rax,[rbp-38]
       jne       near ptr M01_L14
M01_L05:
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D50EF58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
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
       mov       rdx,7FF95D6B98A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C941048
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
       call      qword ptr [7FF95D50EF58]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D6B97D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD14F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD14F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FF95C941050
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
       mov       r11,7FF95C941050
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
; Total bytes of code 607
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
M02_L00:
       xor       eax,eax
       test      ecx,ecx
       sete      al
       ret
M02_L01:
       mov       ecx,1
       jmp       short M02_L00
; Total bytes of code 33
```
```assembly
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
       call      qword ptr [7FF95CA841F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1D1E540D110
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
       call      qword ptr [7FF95D52DAA0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,1D1E540D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95CAA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D1E540D110
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
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
       mov       rdx,7FF95D733010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L14
M01_L05:
       mov       rax,[rbp-38]
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D597258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
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
       mov       rdx,7FF95D733010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C961250
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
       call      qword ptr [7FF95D597258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D732F38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD34F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD34F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FF95C961258
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
       mov       r11,7FF95C961258
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
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
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
       call      qword ptr [7FF95CAA41F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,23FBD40D110
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
       call      qword ptr [7FF95D50EA30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,23FBD40D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF95D623FA8
       call      qword ptr [7FF95CA94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,23FBD40D110
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,7FF95D623FA8
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
       mov       rdx,7FF95D765DC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L14
M01_L05:
       mov       rax,[rbp-38]
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D62C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
       mov       rcx,[rbp-38]
       call      qword ptr [r11]
       mov       rdx,7FF95D623FA8
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
       mov       rdx,7FF95D765DC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C951878
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
       call      qword ptr [7FF95D62C378]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D765CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD24F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD24F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FF95C951880
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
       mov       r11,7FF95C951880
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
```
```assembly
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
       call      qword ptr [7FF95CA941F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1DC2200D110
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
       call      qword ptr [7FF95D6DD5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M00_L01:
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
       mov       rdx,1DC2200D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF95CA94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DC2200D110
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       test      rsi,rsi
       jne       short M00_L00
M00_L03:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 159
```
```assembly
; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp-40],rsp
       mov       [rbp-30],rcx
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
       mov       [rbp-38],rax
       test      rax,rax
       je        near ptr M01_L11
       mov       rdi,[rax]
       mov       r14,offset MT_System.Collections.Generic.SortedSet`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       rdi,r14
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L01:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L03
M01_L02:
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
       mov       rdx,7FF95D75D810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L02
M01_L04:
       mov       rdx,rax
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       jne       near ptr M01_L14
M01_L05:
       mov       rax,[rbp-38]
       mov       rdx,rdi
       lea       rcx,[rax+8]
       call      qword ptr [7FF95D744840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M01_L18
       jmp       near ptr M01_L01
M01_L06:
       mov       rcx,[rsi+10]
       mov       r11,[rcx+28]
       test      r11,r11
       je        short M01_L08
M01_L07:
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
       mov       rdx,7FF95D75D810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FF95C951998
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
       call      qword ptr [7FF95D744840]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FF95D75D738
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L14:
       cmp       rdi,r14
       jne       short M01_L19
M01_L15:
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
       call      qword ptr [7FF95CD24F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FF95CD24F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FF95C9519A0
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
       mov       r11,7FF95C9519A0
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
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       mov       rax,[rdx+30]
       test      rax,rax
       je        short M02_L00
       cmp       dword ptr [rax+8],0
       sete      al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       mov       eax,1
M02_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 35
```
```assembly
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
       call      qword ptr [7FF95CA941F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setle     cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       ecx,1
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 86
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rsi],rcx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       cmp       dword ptr [rsi+20],0
       setg      cl
M00_L01:
       mov       rdx,[rbx+18]
       mov       [rdx+4C],cl
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       jmp       short M00_L00
; Total bytes of code 83
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,1F386401FF8
       mov       rcx,[rcx]
       call      qword ptr [7FF95D54DE48]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D54E388]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D5822B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D55B800
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D54FEB8]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D5947E0]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D54DE48]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D581AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D5940D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D62EEB0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D54E340]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,13900C01FF8
       mov       rcx,[rcx]
       call      qword ptr [7FF95D5741B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D5746F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D582708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D552968
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D576220]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D576AD8]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D5741B0]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D581F08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D5763D0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D63CF80]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D5746A8]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,131F9801FF8
       mov       rcx,[rcx]
       call      qword ptr [7FF95D51F810]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D51FD50]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D562580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D5401E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D555968]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D556220]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D51F810]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D561D80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D555B18]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D61C200]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D51FD08]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,21102C01FF8
       mov       rcx,[rcx]
       call      qword ptr [7FF95D51F810]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D51FD50]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D562580
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D5401E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D555968]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D556220]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D51F810]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D561D80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D555B18]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D61CB40]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D51FD08]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,2EAF1C01FF8
       mov       rcx,[rcx]
       call      qword ptr [7FF95D5641B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D5646F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D572708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D540630
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D566220]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D566AD8]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D5641B0]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D571F08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D5663D0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D62C0E0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D5646A8]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,1E20E802000
       mov       rcx,[rcx]
       call      qword ptr [7FF95D597738]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D597C78]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D5C2708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D5A03E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D59D7D0]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D59E088]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D597738]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D5C1F08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D59D980]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D64F240]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D597C30]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,2C828C124D0
       mov       rcx,[rcx]
       call      qword ptr [7FF95D64CC00]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D64D140]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D667EC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D654CD0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D64EC70]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D64F528]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D64CC00]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D6676C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D64EE20]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D5E6CC0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D64D0F8]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,242B00124E0
       mov       rcx,[rcx]
       call      qword ptr [7FF95D7650F8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
```
```assembly
; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       [rsp+30],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rbx
       mov       rbp,[rcx]
       cmp       rbp,rdi
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+30]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       rbp,rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D765638]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FF95D7922B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       short M01_L01
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       ecx,4D7
       mov       rdx,7FF95D75BB50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D767168]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FF95D767A20]
       mov       rcx,rax
M01_L08:
       mov       rdx,[rcx+10]
       cmp       rdx,[rsi+10]
       jne       short M01_L02
       mov       rdx,[rcx+8]
       cmp       qword ptr [rdx+10],0
       jne       short M01_L09
       mov       rax,rsi
       jmp       short M01_L05
M01_L09:
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
       call      qword ptr [7FF95D7650F8]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FF95D791AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FF95D767318]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FF95D7BAD90]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D7655F0]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

