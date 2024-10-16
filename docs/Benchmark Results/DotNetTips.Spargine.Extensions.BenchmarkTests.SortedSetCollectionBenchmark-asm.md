## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,122AF40CEF0
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
       call      qword ptr [7FFBF9F54930]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,122AF40CEE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFBF9F89FB0
       call      qword ptr [7FFBF9554210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,122AF40CEF0
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
       mov       rdx,7FFBF9F89FB0
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
       mov       rdx,7FFBFA0D12C0
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
       call      qword ptr [7FFBF9F8E340]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBF9F89FB0
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
       mov       rdx,7FFBFA0D12C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF9410E40
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
       call      qword ptr [7FFBF9F8E340]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA0D11E8
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
       call      qword ptr [7FFBF97D4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97D4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FFBF9410E48
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
       mov       r11,7FFBF9410E48
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
       call      qword ptr [7FFBF95541F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1874980CEF0
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
       call      qword ptr [7FFBF9F46178]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1874980CEE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFBF9F7BAE0
       call      qword ptr [7FFBF9544210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1874980CEF0
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
       mov       rdx,7FFBF9F7BAE0
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
       mov       rdx,7FFBFA0D0250
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
       call      qword ptr [7FFBF9F7FE70]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBF9F7BAE0
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
       mov       rdx,7FFBFA0D0250
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF9400E40
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
       call      qword ptr [7FFBF9F7FE70]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA0D0178
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
       call      qword ptr [7FFBF97C4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97C4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FFBF9400E48
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
       mov       r11,7FFBF9400E48
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
       call      qword ptr [7FFBF95441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,20FCD80CEF0
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
       call      qword ptr [7FFBF9F66730]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,20FCD80CEE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFBF9F9BDF8
       call      qword ptr [7FFBF9564210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20FCD80CEF0
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
       mov       rdx,7FFBF9F9BDF8
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
       mov       rdx,7FFBFA0E0180
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
       call      qword ptr [7FFBF9FC4288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBF9F9BDF8
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
       mov       rdx,7FFBFA0E0180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF9420E40
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
       call      qword ptr [7FFBF9FC4288]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA0E00A8
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
       call      qword ptr [7FFBF97E4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97E4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFBF9420E48
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
       mov       r11,7FFBF9420E48
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
       call      qword ptr [7FFBF95641F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1FC0380CEF0
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
       call      qword ptr [7FFBF9F36178]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1FC0380CEE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFBF9F6BA98
       call      qword ptr [7FFBF9534210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FC0380CEF0
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
       mov       rdx,7FFBF9F6BA98
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
       mov       rdx,7FFBFA0C0590
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
       call      qword ptr [7FFBF9F6FE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBF9F6BA98
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
       mov       rdx,7FFBFA0C0590
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF93F0E40
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
       call      qword ptr [7FFBF9F6FE28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA0C04B8
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
       call      qword ptr [7FFBF97B4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97B4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,rax
       mov       r11,7FFBF93F0E48
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
       mov       r11,7FFBF93F0E48
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
       call      qword ptr [7FFBF95341F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,2E5CD00CEF0
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
       call      qword ptr [7FFBF9F67A38]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,2E5CD00CEE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFBF9FC1200
       call      qword ptr [7FFBF9564210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2E5CD00CEF0
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
       mov       rdx,7FFBF9FC1200
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
       mov       rdx,7FFBFA0F8B80
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
       call      qword ptr [7FFBF9FC5590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBF9FC1200
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
       mov       rdx,7FFBFA0F8B80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF9420F58
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
       call      qword ptr [7FFBF9FC5590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA0F8AA8
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
       call      qword ptr [7FFBF97E4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97E4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFBF9420F60
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
       mov       r11,7FFBF9420F60
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
       call      qword ptr [7FFBF95641F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1D61180CEF0
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
       call      qword ptr [7FFBF9FA7738]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1D61180CEE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFBF9544210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D61180CEF0
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
       mov       rdx,7FFBFA1958C8
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
       call      qword ptr [7FFBFA005590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBFA1958C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF9401000
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
       call      qword ptr [7FFBFA005590]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA1957F0
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
       call      qword ptr [7FFBF97C4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97C4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFBF9401008
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
       mov       r11,7FFBF9401008
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
       call      qword ptr [7FFBF95441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,2C18CC0CEF0
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
       call      qword ptr [7FFBF9F8E220]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,2C18CC0CEE8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFBF9534210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2C18CC0CEF0
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
       mov       rdx,7FFBFA1A5B70
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
       call      qword ptr [7FFBFA007E28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBFA1A5B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF93F1598
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
       call      qword ptr [7FFBFA007E28]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA1A5A98
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
       call      qword ptr [7FFBF97B4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97B4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFBF93F15A0
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
       mov       r11,7FFBF93F15A0
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
       call      qword ptr [7FFBF95341F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       r8,1C843C0AEF8
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
       call      qword ptr [7FFBFA06D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       mov       rdx,1C843C0AEF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFBFA162AF0
       call      qword ptr [7FFBF9544210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C843C0AEF8
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
       mov       rdx,7FFBFA162AF0
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
       mov       rdx,7FFBFA1C5EF0
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
       call      qword ptr [7FFBFA166E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rdx,7FFBFA162AF0
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
       mov       rdx,7FFBFA1C5EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       short M01_L07
M01_L09:
       mov       rcx,rax
       mov       r11,7FFBF9401748
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
       call      qword ptr [7FFBFA166E80]; System.Collections.Generic.SortedSet`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L12:
       test      eax,eax
       je        short M01_L18
       jmp       near ptr M01_L06
M01_L13:
       mov       rcx,rsi
       mov       rdx,7FFBFA1C5E18
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
       call      qword ptr [7FFBF97C4F30]
       int       3
M01_L17:
       mov       ecx,0C
       call      qword ptr [7FFBF97C4F30]
       int       3
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp-38]
       mov       r11,7FFBF9401750
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
       mov       r11,7FFBF9401750
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
       call      qword ptr [7FFBF95441F8]
       int       3
; Total bytes of code 44
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,1D985001FD8
       mov       rcx,[rcx]
       call      qword ptr [7FFBF9F9EBF8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+78]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9F9F138]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA110AA8
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
       mov       rdx,7FFBF9FAA608
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9F9FF30]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FD46A8]
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
       call      qword ptr [7FFBF9F9EBF8]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA110A58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBF9FD47F8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBF9F25EA8]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9F9F0F0]
       jmp       near ptr M01_L05
; Total bytes of code 356
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,1CB7FC01FD8
       mov       rcx,[rcx]
       call      qword ptr [7FFBF9FA4BE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+78]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FA5128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA0F0160
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
       mov       rdx,7FFBF9F8DD40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FA5F20]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FA6688]
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
       call      qword ptr [7FFBF9FA4BE8]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA0F0110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBF9FA67D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBF9F06E78]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FA50E0]
       jmp       near ptr M01_L05
; Total bytes of code 356
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,1730CC01FD8
       mov       rcx,[rcx]
       call      qword ptr [7FFBF9FD4BE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+78]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FD5128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA1205A8
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
       mov       rdx,7FFBF9FBDD40
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FD5F20]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FD6688]
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
       call      qword ptr [7FFBF9FD4BE8]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA120558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBF9FD67D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBF9F33EF8]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FD50E0]
       jmp       near ptr M01_L05
; Total bytes of code 356
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,18143401FD8
       mov       rcx,[rcx]
       call      qword ptr [7FFBF9FB4BE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+78]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FB5128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA100D98
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
       mov       rdx,7FFBF9F9E170
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FB5F20]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FB6688]
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
       call      qword ptr [7FFBF9FB4BE8]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA100D48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBF9FB67D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBF9F13828]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FB50E0]
       jmp       near ptr M01_L05
; Total bytes of code 356
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,1D920001FD8
       mov       rcx,[rcx]
       call      qword ptr [7FFBF9FC4BE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+78]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FC5128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA110938
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
       mov       rdx,7FFBF9FAE170
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF9FC5F20]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9FC6688]
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
       call      qword ptr [7FFBF9FC4BE8]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA1108E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBF9FC67D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBF9F22E88]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBF9FC50E0]
       jmp       near ptr M01_L05
; Total bytes of code 356
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,12924801FE0
       mov       rcx,[rcx]
       call      qword ptr [7FFBFA006568]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+78]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBFA006AA8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA1A8FF8
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
       mov       rdx,7FFBF9FF8C80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA0078A0]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA00C318]
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
       call      qword ptr [7FFBFA006568]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA1A8FA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBFA00C468]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBFA12A698]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBFA006A60]
       jmp       near ptr M01_L05
; Total bytes of code 356
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,1CECD801FF0
       mov       rcx,[rcx]
       call      qword ptr [7FFBFA07CBE8]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        short M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+78]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBFA07D128]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA202638
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
       mov       rdx,7FFBFA0866D0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA07DF20]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA07E688]
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
       call      qword ptr [7FFBFA07CBE8]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA2025E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBFA07E7D8]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBFA137138]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBFA07D0E0]
       jmp       near ptr M01_L05
; Total bytes of code 356
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.ToImmutableSortedSet()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+278]
       mov       rcx,286DE402010
       mov       rcx,[rcx]
       call      qword ptr [7FFBFA157738]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].Union(System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       je        near ptr M01_L08
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        short M01_L04
M01_L01:
       mov       rcx,rbx
       cmp       [rcx],rax
       je        short M01_L07
M01_L02:
       mov       rcx,[rsi+8]
       cmp       qword ptr [rcx+10],0
       jne       near ptr M01_L11
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBFA157C78]; System.Collections.Immutable.ImmutableSortedSet`1[[System.__Canon, System.Private.CoreLib]].LeafToRootRefill(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFBFA1F2218
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
       mov       rdx,7FFBFA146BE8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBFA15CA98]
       int       3
M01_L07:
       cmp       [rcx],ecx
       call      qword ptr [7FFBFA15D200]
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
       call      qword ptr [7FFBFA157738]
       jmp       short M01_L05
M01_L11:
       mov       rcx,[rdi+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdi
       mov       rdx,7FFBFA1F21C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       lea       r8,[rsp+20]
       mov       rdx,rbx
       call      qword ptr [7FFBFA15D350]; System.Collections.Immutable.ImmutableExtensions.TryGetCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       test      eax,eax
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+20]
       add       ecx,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2ss xmm0,xmm0,ecx
       vmulss    xmm0,xmm0,dword ptr [7FFBFA0ACDC0]
       mov       rcx,[rsi+8]
       vxorps    xmm1,xmm1,xmm1
       vcvtsi2ss xmm1,xmm1,dword ptr [rcx+20]
       vucomiss  xmm0,xmm1
       ja        near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBFA157C30]
       jmp       near ptr M01_L05
; Total bytes of code 366
```

