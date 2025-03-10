## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1E641C0B118
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
       call      qword ptr [7FFE18EB46A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1E641C0B110
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE18464210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E641C0B118
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
       mov       rdx,7FFE190A7140
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
       call      qword ptr [7FFE18EFE340]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE190A7140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE18321138
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
       call      qword ptr [7FFE18EFE340]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE190A7068
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
       call      qword ptr [7FFE186F4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE186F4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FFE18321140
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
       mov       r11,7FFE18321140
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
       call      qword ptr [7FFE184641F8]
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
       mov       r8,21D2240B118
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
       call      qword ptr [7FFE18EE6B68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,21D2240B110
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE18494210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,21D2240B118
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
       mov       rdx,7FFE190C87F0
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
       call      qword ptr [7FFE18F44468]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE190C87F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE18351138
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
       call      qword ptr [7FFE18F44468]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE190C8718
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
       call      qword ptr [7FFE18724F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE18724F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFE18351140
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
       mov       r11,7FFE18351140
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
       call      qword ptr [7FFE184941F8]
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
       mov       r8,1C69FC0D110
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
       call      qword ptr [7FFE18EE5A58]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1C69FC0D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE18494210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C69FC0D110
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
       mov       rdx,7FFE190C8FD0
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
       call      qword ptr [7FFE18F2F7C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE190C8FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE18351138
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
       call      qword ptr [7FFE18F2F7C8]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE190C8EF8
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
       call      qword ptr [7FFE18724F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE18724F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FFE18351140
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
       mov       r11,7FFE18351140
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
       call      qword ptr [7FFE184941F8]
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
       mov       r8,1AB4040D110
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
       call      qword ptr [7FFE18EF6B68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1AB4040D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE184A4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AB4040D110
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
       mov       rdx,7FFE190D91A0
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
       call      qword ptr [7FFE18F54468]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE190D91A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE18361140
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
       call      qword ptr [7FFE18F54468]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE190D90C8
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
       call      qword ptr [7FFE18734F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE18734F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFE18361148
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
       mov       r11,7FFE18361148
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
       call      qword ptr [7FFE184A41F8]
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
       mov       r8,24FFC00D110
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
       call      qword ptr [7FFE18EB6B68]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,24FFC00D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE18464210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,24FFC00D110
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
       mov       rdx,7FFE19099610
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
       call      qword ptr [7FFE18F14468]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE19099610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE18321138
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
       call      qword ptr [7FFE18F14468]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE19099538
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
       call      qword ptr [7FFE186F4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE186F4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFE18321140
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
       mov       r11,7FFE18321140
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
       call      qword ptr [7FFE184641F8]
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
       mov       r8,153C440D110
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
       call      qword ptr [7FFE18F0D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,153C440D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE18484210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,153C440D110
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
       mov       rdx,7FFE19111DA8
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
       call      qword ptr [7FFE18F77258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE19111DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE18341308
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
       call      qword ptr [7FFE18F77258]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE19111CD0
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
       call      qword ptr [7FFE18714F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE18714F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFE18341310
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
       mov       r11,7FFE18341310
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
       call      qword ptr [7FFE184841F8]
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
       mov       r8,2BDC5C0D110
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
       call      qword ptr [7FFE18EEFCA8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,2BDC5C0D108
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE18FF9200
       call      qword ptr [7FFE18474210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2BDC5C0D110
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
       mov       rdx,7FFE18FF9200
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
       mov       rdx,7FFE19145E40
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
       call      qword ptr [7FFE18FFD590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE18FF9200
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
       mov       rdx,7FFE19145E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE183319D0
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
       call      qword ptr [7FFE18FFD590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE19145D68
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
       call      qword ptr [7FFE18704F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE18704F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFE183319D8
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
       mov       r11,7FFE183319D8
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
       call      qword ptr [7FFE184741F8]
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
       mov       r8,1E34900B118
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
       call      qword ptr [7FFE190BE778]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1E34900B110
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE18474210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E34900B118
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
       mov       rdx,7FFE1913DD00
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
       call      qword ptr [7FFE19125F20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFE1913DD00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFE18331C30
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
       call      qword ptr [7FFE19125F20]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFE1913DC28
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
       call      qword ptr [7FFE18704F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFE18704F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFE18331C38
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
       mov       r11,7FFE18331C38
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
       call      qword ptr [7FFE184741F8]
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
       mov       rcx,23E65C01FF8
       mov       rcx,[rcx]
       call      qword ptr [7FFE18F241B0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE18F246F0]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE18F322B0
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
       mov       rdx,7FFE18EFE9C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F26220]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F26AD8]
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
       call      qword ptr [7FFE18F241B0]
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
       mov       rdx,7FFE18F31AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE18F263D0]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE18FF0DF0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F246A8]
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
       mov       rcx,17212001FF8
       mov       rcx,[rcx]
       call      qword ptr [7FFE18F34D20]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE18F35260]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE18F52580
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
       mov       rdx,7FFE18F22308
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F36D90]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F37648]
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
       call      qword ptr [7FFE18F34D20]
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
       mov       rdx,7FFE18F51D80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE18F36F40]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE1900F000]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F35218]
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
       mov       rcx,1A59B401FF8
       mov       rcx,[rcx]
       call      qword ptr [7FFE18F25440]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE18F25980]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE18F42708
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
       mov       rdx,7FFE18F128E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F274B0]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F27D68]
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
       call      qword ptr [7FFE18F25440]
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
       mov       rdx,7FFE18F41F08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE18F27660]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE18FFE4A0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F25938]
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
       mov       rcx,14C48801FF8
       mov       rcx,[rcx]
       call      qword ptr [7FFE18F14D20]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE18F15260]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE18F32580
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
       mov       rdx,7FFE18F02308
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F16D90]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F17648]
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
       call      qword ptr [7FFE18F14D20]
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
       mov       rdx,7FFE18F31D80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE18F16F40]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE18FEE7E0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F15218]
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
       mov       rcx,1C309401FF8
       mov       rcx,[rcx]
       call      qword ptr [7FFE18F35440]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE18F35980]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE18F52708
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
       mov       rdx,7FFE18F228E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F374B0]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F37D68]
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
       call      qword ptr [7FFE18F35440]
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
       mov       rdx,7FFE18F51F08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE18F37660]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE1900E440]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F35938]
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
       mov       rcx,1F3D6C02000
       mov       rcx,[rcx]
       call      qword ptr [7FFE18F8D440]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE18F8D980]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE18FB3D08
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
       mov       rdx,7FFE18FA1780
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F8F4B0]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F8FD68]
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
       call      qword ptr [7FFE18F8D440]
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
       mov       rdx,7FFE18FB3508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE18F8F660]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE190449C0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F8D938]
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
       mov       rcx,27B9D012500
       mov       rcx,[rcx]
       call      qword ptr [7FFE1900DE48]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE1900E388]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE19035D20
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
       mov       rdx,7FFE19023E70
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE1900FEB8]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE190447E0]
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
       call      qword ptr [7FFE1900DE48]
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
       mov       rdx,7FFE19035520
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE190440D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE18FB8940]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1900E340]
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
       mov       rcx,17BD1410518
       mov       rcx,[rcx]
       call      qword ptr [7FFE19146DA8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FFE191472E8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFE191722B0
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
       mov       rdx,7FFE1913DF50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE1914CE70]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFE1914D728]
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
       call      qword ptr [7FFE19146DA8]
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
       mov       rdx,7FFE19171AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+28]
       mov       rdx,rbx
       call      qword ptr [7FFE1914D020]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+28]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFE1919C950]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE191472A0]
       jmp       near ptr M01_L05
; Total bytes of code 361
```

