## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark.HasItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+180]
       mov       r8,178AA80AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE38906CD0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38906D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,178AA80AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38054210]
       mov       rcx,178AA80AC40
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
       cmp       dword ptr [7FFE384EF588],0
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
       mov       rdx,7FFE388EAFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38887888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38907360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFE384ECAF0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFE384FE130]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
       mov       rsi,[rbx+180]
       mov       r8,1956600AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE38906CD0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38906D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1956600AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38054210]
       mov       rcx,1956600AC40
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
       cmp       dword ptr [7FFE384EF588],0
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
       mov       rdx,7FFE388EAFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38887888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38907360]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFE384ECAF0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFE384FE130]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
       mov       rsi,[rbx+180]
       mov       r8,26FF840AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE38906B20]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38906B50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,26FF840AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedSetCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFE38054210]
       mov       rcx,26FF840AC40
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
       cmp       dword ptr [7FFE384EF588],0
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
       mov       rdx,7FFE388EADE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE38887888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389071B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       call      qword ptr [7FFE384ECAF0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFE384FE130]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
       mov       rsi,[rbx+180]
       mov       r8,13362C0AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE3899E028]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE3899E058]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,13362C0AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE38999FB0
       call      qword ptr [7FFE38044210]
       mov       rcx,13362C0AC40
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
       cmp       dword ptr [7FFE384DF588],0
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
       mov       rdx,7FFE38909640
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE3887ECB8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3899E6B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rsi,[rbx+180]
       mov       r8,25AE4C08C48
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE38A07E70]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE38A07EA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,25AE4C08C40
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE38A03DF8
       call      qword ptr [7FFE38054210]
       mov       rcx,25AE4C08C48
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
       cmp       dword ptr [7FFE384EF588],0
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
       mov       rdx,7FFE389E6B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE3890CC30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0C600]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rsi,[rbx+180]
       mov       r8,27ABA40AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE389ED428]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE389ED458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,27ABA40AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE389E93B0
       call      qword ptr [7FFE38024210]
       mov       rcx,27ABA40AC40
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
       cmp       dword ptr [7FFE384BF588],0
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
       mov       rdx,7FFE389D83B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE388DDE30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389EDAA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rsi,[rbx+180]
       mov       r8,287BDC0AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE389FD428]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE389FD458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,287BDC0AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE389F93B0
       call      qword ptr [7FFE38034210]
       mov       rcx,287BDC0AC40
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
       cmp       dword ptr [7FFE384CF588],0
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
       mov       rdx,7FFE389E6C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE3897DE30]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389FDAA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rsi,[rbx+180]
       mov       r8,2CA4E40AC40
       mov       r8,[r8]
       test      r8,r8
       je        short M00_L01
M00_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
       call      qword ptr [7FFE389FC8D0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE389FC900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
M00_L01:
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2CA4E40AC38
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,7FFE389F8858
       call      qword ptr [7FFE38034210]
       mov       rcx,2CA4E40AC40
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
       cmp       dword ptr [7FFE384CF588],0
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
       mov       rdx,7FFE389E6F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M01_L05:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFE3897D5A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       cmp       dword ptr [7FFE3837F438],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389FCF48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,1E1DE001F90
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE384F7918]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38904DB0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38904DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       mov       rax,[rdx+78]
       test      rax,rax
       je        near ptr M01_L07
       mov       rcx,rax
M01_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE38054360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L08
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rax,[rcx+98]
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
       call      qword ptr [7FFE38884A38]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38AAD248
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FFE38AAD180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L08:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+80]
       test      rcx,rcx
       je        short M01_L12
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE388845A0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rcx,[rcx+88]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L12:
       mov       rcx,r14
       mov       rdx,7FFE38AAD1C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FFE38AAD210
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3834C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       r15d,1
       mov       esi,1
       jmp       near ptr M01_L19
M01_L15:
       mov       rcx,[r14+30]
       mov       rcx,[rcx]
       mov       r11,[rcx+90]
       test      r11,r11
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,7FFE38AAD230
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
       mov       rcx,[rcx+78]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,r14
       mov       rdx,7FFE38AAD180
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE384F7CF0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,[rdx+70]
       test      rdx,rdx
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FFE38AAD110
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE3839C210]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3827F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382B66E8]
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
; Total bytes of code 833
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
       cmp       dword ptr [7FFE384EF588],0
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
       call      qword ptr [7FFE384FC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE383AF3F0],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38906238]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,161C2401F90
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE384DC708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE388E6C88]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388E6CB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FFE38034360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE38866220]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38A8C7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FFE38A8C730
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
       call      qword ptr [7FFE38865D88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFE38A8C770
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FFE38A8C7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3832C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFE38A8C7E0
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
       mov       rdx,7FFE38A8C730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE384DCAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFE38A8C6C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE3838CAB0]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3825F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382966E8]
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
       cmp       dword ptr [7FFE384CF588],0
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
       call      qword ptr [7FFE384DCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3837F410],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388EC270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,17C38801F90
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE384FC708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38906C88]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38906CB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FFE38054360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE38886478]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38AAC8E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FFE38AAC818
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
       call      qword ptr [7FFE38885FE0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFE38AAC858
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       short M01_L09
M01_L13:
       mov       rcx,r14
       mov       rdx,7FFE38AAC8A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3834C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFE38AAC8C8
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
       mov       rdx,7FFE38AAC818
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE384FCAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFE38AAC7A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE38396C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3827F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382B66E8]
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
       cmp       dword ptr [7FFE384EF588],0
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
       call      qword ptr [7FFE384FCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3890C270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,1A7B6401F90
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE384EC708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389ADFE0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE389AE010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FFE38044360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE3887D8A8]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38AB8888
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FFE38AB87C0
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
       mov       rdx,7FFE38AB8800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE3887D410]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFE38AB8850
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3833C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFE38AB8870
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
       mov       rdx,7FFE38AB87C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE384ECAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFE38AB8750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE38386C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3826F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382A66E8]
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
       cmp       dword ptr [7FFE384DF588],0
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
       call      qword ptr [7FFE384ECE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389AF468]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,1A88E001F98
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE384CC708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389ECD50]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE389ECD80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FFE38024360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE388DCA20]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38AB5250
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FFE38AB5188
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
       mov       rdx,7FFE38AB51C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE388DC588]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFE38AB5218
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3831C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFE38AB5238
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
       mov       rdx,7FFE38AB5188
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE384CCAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFE38AB5118
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE38366C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3824F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382866E8]
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
       cmp       dword ptr [7FFE384BF588],0
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
       call      qword ptr [7FFE384CCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389EE1C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,1355DC01FA0
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE384CC708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389ED3E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE389ED410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FFE38024360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE388DCA20]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38AB42F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE38AB43B8
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
       mov       rdx,7FFE38AB4330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE388DC588]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFE38AB4380
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       mov       [rsp+20],rdi
       mov       rdx,rsi
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3831C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFE38AB43A0
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
       mov       rdx,7FFE38AB42F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L20:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE384CCAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFE38AB4280
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE38366C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3824F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382866E8]
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
       cmp       dword ptr [7FFE384BF588],0
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
       call      qword ptr [7FFE384CCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389EE850]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,2BB44401FA0
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE3850C708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A2D3E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38A2D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FFE38064360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE389ACA20]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38AF3490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L07:
       mov       rcx,r14
       mov       rdx,7FFE38AF3558
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
       mov       rdx,7FFE38AF34D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE389AC588]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFE38AF3520
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L13:
       mov       [rsp+20],rdi
       mov       rdx,rsi
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3835C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFE38AF3540
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
       mov       rdx,7FFE38AF3490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L20:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE3850CAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFE38AF3420
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE383A6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3828F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382C66E8]
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
       cmp       dword ptr [7FFE384FF588],0
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
       call      qword ptr [7FFE3850CE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE383BF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A2E850]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       r8,15B6B001F98
       mov       r8,[r8]
       mov       rcx,rsi
       call      qword ptr [7FFE384EC708]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Collections.Generic.IComparer`1<System.__Canon>)
       mov       rdx,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A0D3E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38A0D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       call      qword ptr [7FFE38044360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE3898CA20]; System.Collections.Generic.SortedSet`1+Node[[System.__Canon, System.Private.CoreLib]].DeepClone(Int32)
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
       mov       rdx,7FFE38AD4D78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M01_L02
M01_L07:
       mov       rdx,7FFE38AD4CB0
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
       mov       rdx,7FFE38AD4CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       lea       r8,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFE3898C588]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32 ByRef)
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
       mov       rdx,7FFE38AD4D40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L14:
       mov       [rsp+20],rdi
       mov       rdx,r13
       mov       r9d,[rsp+30]
       xor       r8d,r8d
       call      qword ptr [7FFE3833C2B8]; System.Array.Sort[[System.__Canon, System.Private.CoreLib]](System.__Canon[], Int32, Int32, System.Collections.Generic.IComparer`1<System.__Canon>)
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
       mov       rdx,7FFE38AD4D60
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
       mov       rdx,7FFE38AD4CB0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L21:
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9d,[rsp+30]
       dec       r9d
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FFE384ECAE0]; System.Collections.Generic.SortedSet`1[[System.__Canon, System.Private.CoreLib]].ConstructRootFromSortedArray(System.__Canon[], Int32, Int32, Node<System.__Canon>)
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
       mov       rdx,7FFE38AD4C40
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L24:
       mov       rcx,rdx
       call      qword ptr [7FFE38386C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rdx,rax
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M01_L00
M01_L25:
       mov       ecx,7D7
       mov       rdx,7FFE3826F3A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE382A66E8]
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
       cmp       dword ptr [7FFE384DF588],0
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
       call      qword ptr [7FFE384ECE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0E850]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38904DB0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38904DE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384EF588],0
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
       call      qword ptr [7FFE384FC090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389053F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38906C88]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38906CB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384EF588],0
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
       call      qword ptr [7FFE384FCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389072D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389153E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38915410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384FF588],0
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
       call      qword ptr [7FFE3850C090]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE383BF380],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38915A28]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE388E6C88]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388E6CB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384CF588],0
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
       call      qword ptr [7FFE384DCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E72D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A1D3E0]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38A1D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384EF588],0
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
       call      qword ptr [7FFE384FCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A1DA10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389FD230]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE389FD260]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384CF588],0
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
       call      qword ptr [7FFE384DCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389FD860]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE38A0CD50]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38A0CD80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384DF588],0
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
       call      qword ptr [7FFE384ECE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0D380]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,[rbx+180]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedSet`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE389ECD50]; DotNetTips.Spargine.Extensions.SortedSetExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedSet`1<System.__Canon>)
       mov       edx,eax
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE389ECD80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
       cmp       dword ptr [7FFE384BF588],0
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
       call      qword ptr [7FFE384CCE10]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389ED380]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

