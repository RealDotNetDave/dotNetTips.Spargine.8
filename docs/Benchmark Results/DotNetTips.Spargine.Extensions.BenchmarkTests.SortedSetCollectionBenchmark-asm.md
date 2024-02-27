## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,244AE80AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF81536FB40]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF81536FB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,244AE80AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF814AF4210]
       mov       rcx,244AE80AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F8F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815384778
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF815324AB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E4F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153A4270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF814F8CA48]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF814F9DD10]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,1C55A00AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF815365428]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF815365458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C55A00AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF814AB4210]
       mov       rcx,1C55A00AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F4F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815346490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF8152E61D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815365AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF814F4CA48]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF814F5DD10]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,1ADA140AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF815384900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1ADA140AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF814AD4210]
       mov       rcx,1ADA140AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F6F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8153664A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF8153052C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E2F3F0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815384F60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF814F6CA48]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF814F7CF90]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,23C5F80AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF815395F80]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF815395FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,23C5F80AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FF814AD4210]
       mov       rcx,23C5F80AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F6F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815377CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF815316D30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E2F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815396610]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       sub       rsp,28
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FF814F6CA48]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF814F7DD10]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
; Total bytes of code 28
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,1D38FC0AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF815467270]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8154672A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D38FC0AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF8154631F8
       call      qword ptr [7FF814AC4210]
       mov       rcx,1D38FC0AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F5F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815455140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF81537C288]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154678E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,20E91C0AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20E91C0AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF8154733A8
       call      qword ptr [7FF814AC4210]
       mov       rcx,20E91C0AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F5F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815465348
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF81538C6A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815477A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,27C3B40AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF8154A7E70]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF8154A7EA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27C3B40AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF8154A3DF8
       call      qword ptr [7FF814AF4210]
       mov       rcx,27C3B40AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F8F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF8154954E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF8153ACD38]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E4F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154AC5E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+188]
       mov       r8,1634800AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FF815487DB0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF815487DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1634800AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FF815483D38
       call      qword ptr [7FF814AD4210]
       mov       rcx,1634800AC40
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M00_L00
; Total bytes of code 145
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-14],rax
       mov       [rbp-0C],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814F6F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M01_L01
       xor       eax,eax
       cmp       qword ptr [rbp+20],0
       sete      al
       mov       [rbp-14],eax
       jmp       short M01_L02
M01_L01:
       mov       dword ptr [rbp-14],1
M01_L02:
       mov       eax,[rbp-14]
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       je        short M01_L03
       nop
       xor       eax,eax
       mov       [rbp-10],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF815475468
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF81538CD38]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-24],eax
       mov       eax,[rbp-24]
       movzx     eax,al
       mov       [rbp-10],eax
       nop
M01_L06:
       mov       eax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 200
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E2F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81548C5E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,2AC50C01F68
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F87870]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF81535EC88]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF81535ECB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L06
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        near ptr M01_L07
M01_L02:
       mov       rcx,rdi
       mov       r15,[rcx]
       cmp       r15,rax
       je        near ptr M01_L09
       mov       rcx,[rbx+10]
       cmp       rcx,[rdi+10]
       jne       near ptr M01_L26
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       r15,rcx
       je        short M01_L04
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[r15+48]
       call      qword ptr [rax+10]
M01_L04:
       mov       ecx,[rdi+20]
       test      ecx,ecx
       jle       short M01_L05
       mov       [rbx+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8152DE538]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF815516370
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF815516438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L08:
       test      eax,eax
       jne       near ptr M01_L03
M01_L09:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r14
       mov       rdx,7FF8155163B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF8152DE0A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rsi,rax
       cmp       dword ptr [rsp+30],0
       jle       near ptr M01_L21
       mov       rdi,[rbx+10]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,r14
       mov       rdx,7FF815516400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       mov       [rsp+20],rdi
       mov       rdx,rsi
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DDC6C0]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebp,1
       mov       r15d,1
       jmp       near ptr M01_L18
M01_L14:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,r14
       mov       rdx,7FF815516420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L16:
       cmp       r15d,[rsi+8]
       jae       near ptr M01_L27
       mov       edx,r15d
       mov       rdx,[rsi+rdx*8+10]
       lea       r8d,[r15-1]
       cmp       r8d,[rsi+8]
       jae       near ptr M01_L27
       lea       r8d,[r15-1]
       mov       r8,[rsi+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
       lea       ecx,[rbp+1]
       mov       r13d,ecx
       mov       ecx,r15d
       mov       rdx,[rsi+rcx*8+10]
       cmp       ebp,[rsi+8]
       jae       near ptr M01_L27
       mov       ecx,ebp
       lea       rcx,[rsi+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,r13d
M01_L17:
       inc       r15d
M01_L18:
       cmp       r15d,[rsp+30]
       jl        near ptr M01_L14
       mov       [rsp+30],ebp
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,r14
       mov       rdx,7FF815516370
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L20:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF814F87C48]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
       mov       [rbx+20],eax
M01_L21:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF815516300
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E3C690]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814D0F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D466E8]
       int       3
M01_L26:
       mov       rcx,[rbx+10]
       mov       rdx,[rdi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 830
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F7F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F8C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E2F3A0],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815394270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,1B03A401F68
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F6C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF81533FE28]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF81533FE58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L07
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L08
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        short M01_L06
M01_L02:
       mov       rcx,r15
       mov       r13,[rcx]
       cmp       r13,rax
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       rcx,[r15+10]
       jne       near ptr M01_L26
M01_L03:
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
       call      qword ptr [7FF8152BF678]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF8154F6548
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FF8154F6480
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF8152BF1E0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       r13,rax
       cmp       dword ptr [rsp+30],0
       jg        short M01_L11
M01_L10:
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
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L12:
       mov       rcx,r14
       mov       rdx,7FF8154F64C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FF8154F6510
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DBC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       esi,1
       jmp       near ptr M01_L19
M01_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,7FF8154F6530
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L17:
       cmp       esi,[r13+8]
       jae       near ptr M01_L27
       mov       edx,esi
       mov       rdx,[r13+rdx*8+10]
       lea       r8d,[rsi-1]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L27
       lea       r8d,[rsi-1]
       mov       r8,[r13+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       ecx,[r15+1]
       mov       ebp,ecx
       mov       ecx,esi
       mov       rdx,[r13+rcx*8+10]
       cmp       r15d,[r13+8]
       jae       near ptr M01_L27
       mov       ecx,r15d
       lea       rcx,[r13+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,ebp
M01_L18:
       inc       esi
M01_L19:
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
       mov       rdx,7FF8154F6480
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF814F6CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF8154F6410
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E06C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814CEF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D266E8]
       int       3
M01_L26:
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
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F5F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F6CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E1F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815375440]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,13A33801F68
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F7C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8153853E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815385410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L07
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L08
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        short M01_L06
M01_L02:
       mov       rcx,r15
       mov       r13,[rcx]
       cmp       r13,rax
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       rcx,[r15+10]
       jne       near ptr M01_L26
M01_L03:
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
       call      qword ptr [7FF815304DC8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF8155264C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FF815526400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L12
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF815304930]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       r13,rax
       cmp       dword ptr [rsp+30],0
       jg        short M01_L11
M01_L10:
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
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L12:
       mov       rcx,r14
       mov       rdx,7FF815526440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FF815526490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DCC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       esi,1
       jmp       near ptr M01_L19
M01_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,7FF8155264B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L17:
       cmp       esi,[r13+8]
       jae       near ptr M01_L27
       mov       edx,esi
       mov       rdx,[r13+rdx*8+10]
       lea       r8d,[rsi-1]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L27
       lea       r8d,[rsi-1]
       mov       r8,[r13+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       ecx,[r15+1]
       mov       ebp,ecx
       mov       ecx,esi
       mov       rdx,[r13+rcx*8+10]
       cmp       r15d,[r13+8]
       jae       near ptr M01_L27
       mov       ecx,r15d
       lea       rcx,[r13+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,ebp
M01_L18:
       inc       esi
M01_L19:
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
       mov       rdx,7FF815526400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF814F7CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF815526390
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E16C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814CFF3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D366E8]
       int       3
M01_L26:
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
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F6F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F7CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815386868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,1AA24401F68
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F9C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8153A53E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8153A5410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L07
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AF4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L08
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        short M01_L06
M01_L02:
       mov       rcx,r15
       mov       r13,[rcx]
       cmp       r13,rax
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       rcx,[r15+10]
       jne       near ptr M01_L26
M01_L03:
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
       call      qword ptr [7FF815324DC8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF815546678
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FF8155465B0
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
       mov       rdx,7FF8155465F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF815324930]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       r13,rax
       cmp       dword ptr [rsp+30],0
       jg        short M01_L11
M01_L10:
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
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L12:
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FF815546640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DEC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       esi,1
       jmp       near ptr M01_L19
M01_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,7FF815546660
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L17:
       cmp       esi,[r13+8]
       jae       near ptr M01_L27
       mov       edx,esi
       mov       rdx,[r13+rdx*8+10]
       lea       r8d,[rsi-1]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L27
       lea       r8d,[rsi-1]
       mov       r8,[r13+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       ecx,[r15+1]
       mov       ebp,ecx
       mov       ecx,esi
       mov       rdx,[r13+rcx*8+10]
       cmp       r15d,[r13+8]
       jae       near ptr M01_L27
       mov       ecx,r15d
       lea       rcx,[r13+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,ebp
M01_L18:
       inc       esi
M01_L19:
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
       mov       rdx,7FF8155465B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF814F9CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF815546540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E36C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814D1F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D566E8]
       int       3
M01_L26:
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
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F8F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F9CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E4F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153A6868]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,22B3EC01F70
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F9C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8154973D8]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815497408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L07
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AF4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L08
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        short M01_L06
M01_L02:
       mov       rcx,r15
       mov       r13,[rcx]
       cmp       r13,rax
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       rcx,[r15+10]
       jne       near ptr M01_L26
M01_L03:
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
       call      qword ptr [7FF8153A7168]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF815552200
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FF815552138
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
       mov       rdx,7FF815552178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF8153A6CD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       r13,rax
       cmp       dword ptr [rsp+30],0
       jg        short M01_L11
M01_L10:
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
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L12:
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FF8155521C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DEC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       esi,1
       jmp       near ptr M01_L19
M01_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,7FF8155521E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L17:
       cmp       esi,[r13+8]
       jae       near ptr M01_L27
       mov       edx,esi
       mov       rdx,[r13+rdx*8+10]
       lea       r8d,[rsi-1]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L27
       lea       r8d,[rsi-1]
       mov       r8,[r13+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       ecx,[r15+1]
       mov       ebp,ecx
       mov       ecx,esi
       mov       rdx,[r13+rcx*8+10]
       cmp       r15d,[r13+8]
       jae       near ptr M01_L27
       mov       ecx,r15d
       lea       rcx,[r13+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,ebp
M01_L18:
       inc       esi
M01_L19:
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
       mov       rdx,7FF815552138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF814F9CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF8155520C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E36C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814D1F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D566E8]
       int       3
M01_L26:
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
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F8F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F9CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E4F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81549C978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,1BAF0C01F70
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F8C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8154A73D8]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154A7408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L06
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L09
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        near ptr M01_L07
M01_L02:
       mov       rcx,rdi
       mov       r15,[rcx]
       cmp       r15,rax
       je        near ptr M01_L09
       mov       rcx,[rbx+10]
       cmp       rcx,[rdi+10]
       jne       near ptr M01_L26
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[System.String, System.Private.CoreLib]]
       cmp       r15,rcx
       je        short M01_L04
       mov       rcx,rdi
       mov       edx,1
       mov       rax,[r15+48]
       call      qword ptr [rax+10]
M01_L04:
       mov       ecx,[rdi+20]
       test      ecx,ecx
       jle       short M01_L05
       mov       [rbx+20],ecx
       mov       rcx,[rdi+8]
       mov       edx,[rbx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153A7168]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF81551EA10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,r14
       mov       rdx,7FF81551EAD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L08:
       test      eax,eax
       jne       near ptr M01_L03
M01_L09:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+70]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r14
       mov       rdx,7FF81551EA50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF8153A6CD0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       rsi,rax
       cmp       dword ptr [rsp+30],0
       jle       near ptr M01_L21
       mov       rdi,[rbx+10]
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,r14
       mov       rdx,7FF81551EAA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       mov       [rsp+20],rdi
       mov       rdx,rsi
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DDC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       ebp,1
       mov       r15d,1
       jmp       near ptr M01_L18
M01_L14:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,r14
       mov       rdx,7FF81551EAC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L16:
       cmp       r15d,[rsi+8]
       jae       near ptr M01_L27
       mov       edx,r15d
       mov       rdx,[rsi+rdx*8+10]
       lea       r8d,[r15-1]
       cmp       r8d,[rsi+8]
       jae       near ptr M01_L27
       lea       r8d,[r15-1]
       mov       r8,[rsi+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
       lea       ecx,[rbp+1]
       mov       r13d,ecx
       mov       ecx,r15d
       mov       rdx,[rsi+rcx*8+10]
       cmp       ebp,[rsi+8]
       jae       near ptr M01_L27
       mov       ecx,ebp
       lea       rcx,[rsi+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ebp,r13d
M01_L17:
       inc       r15d
M01_L18:
       cmp       r15d,[rsp+30]
       jl        near ptr M01_L14
       mov       [rsp+30],ebp
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+68]
       test      rcx,rcx
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,r14
       mov       rdx,7FF81551EA10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L20:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF814F8CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsp+30]
       mov       [rbx+20],eax
M01_L21:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       r14,[rbp]
       mov       rcx,r14
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF81551E9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E26C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814D0F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D466E8]
       int       3
M01_L26:
       mov       rcx,[rbx+10]
       mov       rdx,[rdi+10]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L08
M01_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 830
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F7F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F8CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154AC978]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,27824401F70
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F87870]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8154A6550]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154A6580]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L07
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L08
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        short M01_L06
M01_L02:
       mov       rcx,r15
       mov       r13,[rcx]
       cmp       r13,rax
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       rcx,[r15+10]
       jne       near ptr M01_L26
M01_L03:
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
       call      qword ptr [7FF815425FF8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF81551EA68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FF81551E9A0
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
       mov       rdx,7FF81551E9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF815425B60]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       r13,rax
       cmp       dword ptr [rsp+30],0
       jg        short M01_L11
M01_L10:
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
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L12:
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FF81551EA30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DDC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       esi,1
       jmp       near ptr M01_L19
M01_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,7FF81551EA50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L17:
       cmp       esi,[r13+8]
       jae       near ptr M01_L27
       mov       edx,esi
       mov       rdx,[r13+rdx*8+10]
       lea       r8d,[rsi-1]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L27
       lea       r8d,[rsi-1]
       mov       r8,[r13+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       ecx,[r15+1]
       mov       ebp,ecx
       mov       ecx,esi
       mov       rdx,[r13+rcx*8+10]
       cmp       r15d,[r13+8]
       jae       near ptr M01_L27
       mov       ecx,r15d
       lea       rcx,[r13+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,ebp
M01_L18:
       inc       esi
M01_L19:
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
       mov       rdx,7FF81551E9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF814F87C48]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF81551E930
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E27750]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814D0F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D466E8]
       int       3
M01_L26:
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
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F7F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F8C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E3F380],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154A79C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.DoesNotHaveItems()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.SortedSet`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+188]
       mov       r8,23883C01F70
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FF814F8C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815497D68]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815497D98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 92
```
```assembly
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
       je        near ptr M01_L07
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FF814AE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L08
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+88]
       test      rax,rax
       je        short M01_L06
M01_L02:
       mov       rcx,r15
       mov       r13,[rcx]
       cmp       r13,rax
       je        near ptr M01_L08
       mov       rcx,[rbx+10]
       cmp       rcx,[r15+10]
       jne       near ptr M01_L26
M01_L03:
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
       call      qword ptr [7FF815397918]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L05:
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
       mov       rdx,7FF81551F768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FF81551F6A0
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
       mov       rdx,7FF81551F6E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FF815397480]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
       mov       r13,rax
       cmp       dword ptr [rsp+30],0
       jg        short M01_L11
M01_L10:
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
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L12:
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FF81551F730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FF814DDC2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       esi,1
       jmp       near ptr M01_L19
M01_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+80]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,7FF81551F750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L17:
       cmp       esi,[r13+8]
       jae       near ptr M01_L27
       mov       edx,esi
       mov       rdx,[r13+rdx*8+10]
       lea       r8d,[rsi-1]
       cmp       r8d,[r13+8]
       jae       near ptr M01_L27
       lea       r8d,[rsi-1]
       mov       r8,[r13+r8*8+10]
       mov       rcx,rdi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L18
       lea       ecx,[r15+1]
       mov       ebp,ecx
       mov       ecx,esi
       mov       rdx,[r13+rcx*8+10]
       cmp       r15d,[r13+8]
       jae       near ptr M01_L27
       mov       ecx,r15d
       lea       rcx,[r13+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,ebp
M01_L18:
       inc       esi
M01_L19:
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
       mov       rdx,7FF81551F6A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF814F8CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF81551F630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FF814E26C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FF814D0F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF814D466E8]
       int       3
M01_L26:
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
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F7F4E0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M02_L01
       nop
       mov       dword ptr [rbp-8],1
       nop
       jmp       short M02_L02
M02_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F8CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setle     al
       mov       [rbp-8],eax
       nop
M02_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 107
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81549D428]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8153753E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815375410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F5F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F6CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815375A28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF81533EC88]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81533ECB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F5F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F6C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81533F2D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8153853E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815385410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F6F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F7CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E2F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815385A28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8153946D8]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815394708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F7F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F8C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E3F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815394D20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815465F38]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815465F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F5F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F6C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E0F478],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815466580]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF8154A6700]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154A6730]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F7F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F8C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E3F388],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154A6D30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815497D68]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815497D98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F7F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F8CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E3F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF81549C420]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItems()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+188]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF815486700]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815486730]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
; Total bytes of code 47
```
```assembly
; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-8],eax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F6F4E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+18],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       xor       ecx,ecx
       mov       [rbp-8],ecx
       nop
       jmp       short M01_L02
M01_L01:
       nop
       mov       rcx,[rbp+18]
       call      qword ptr [7FF814F7C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       mov       [rbp-0C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-0C],0
       setg      al
       mov       [rbp-8],eax
       nop
M01_L02:
       mov       eax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF814E2F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF815486D30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

