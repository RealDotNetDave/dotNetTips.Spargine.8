## DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark-20240225-044050
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81535D218]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535D248]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F771F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F3F0],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815395410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81535D218]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535D248]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F771F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F3F0],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81535D218]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535D248]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F771F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F3F0],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81535D218]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154646C0]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535D248]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154646F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F771F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F3F0],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815464708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81535D218]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535D248]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F771F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F3F0],0
+       cmp       dword ptr [7FF814E3F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154948B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81535D218]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535D248]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F771F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F3F0],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81535D218]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81535D248]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F6D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F771F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F77B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F3F0],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81535D260]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
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
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815395410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
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
-       call      qword ptr [7FF815395410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154646C0]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154646F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815395410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815464708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E3F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815395410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154948B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
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
-       call      qword ptr [7FF815395410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F77B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815395410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
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
-       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
        call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154646C0]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154646F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815464708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+18]
        call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E3F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154948B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
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
-       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F77B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154646C0]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154646F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F5D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815464708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E3F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154948B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
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
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536EC70]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536ECA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F77B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536ECB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154646C0]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154646F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815464708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154948B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154646C0]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154646F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F7D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815464708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154646C0]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154646F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F77B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815464708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154948A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F7D648],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M01_L01
        nop
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F388],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154948B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815494870]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154948A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F871F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F77B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F388],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154948B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ReadOnlyCollectionBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ReadOnlyCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        call      qword ptr [7FF8154953C8]; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        jmp       qword ptr [7FF8154953F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ReadOnlyCollectionExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7D648],0
+       cmp       dword ptr [7FF814F6D648],0
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
        mov       dword ptr [rbp-8],1
        nop
        jmp       short M01_L02
 M01_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F87B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F77B28]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        xor       eax,eax
        cmp       dword ptr [rbp-0C],0
        setle     al
        mov       [rbp-8],eax
        nop
 M01_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 107
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
        call      qword ptr [7FF815495410]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
