## DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark-20240225-044619
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DA10]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF815387018]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DA40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815387048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DA10]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DA40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814E3F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
-       call      qword ptr [7FF81539F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DA10]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8153D48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DA40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153D48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153D6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DA10]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF81549FE58]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DA40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81549FE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814E3F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
-       call      qword ptr [7FF81539F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E450C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DA10]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154948B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DA40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
+       cmp       dword ptr [7FF814E0F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815496010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DA10]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DA40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DA10]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DA40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F180]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF815387018]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815387048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF815387018]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8153D48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815387048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153D48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153D6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF815387018]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF81549FE58]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815387048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81549FE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E450C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF815387018]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154948B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815387048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
+       cmp       dword ptr [7FF814E0F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815496010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF815387018]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815387048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M02_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E54BB8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF815387018]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF815387048]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        xor       ecx,ecx
        cmp       qword ptr [rbp+18],0
        sete      cl
        mov       [rbp-4],ecx
        cmp       dword ptr [rbp-4],0
        je        short M02_L01
        nop
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8153D48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153D48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153D6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
        call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF81549FE58]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81549FE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
        cmp       dword ptr [7FF814E3F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E450C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154948B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
+       cmp       dword ptr [7FF814E0F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815496010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF8153D48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF81549FE58]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF8153D48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81549FE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153D6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E450C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF8153D48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154948B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF8153D48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153D6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815496010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF8153D48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF8153D48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153D6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E650C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF8153D48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF8153D48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153D6028]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E450C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81549FE58]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154948B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81549FE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154948E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
+       cmp       dword ptr [7FF814E0F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154B5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815496010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81549FE58]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81549FE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154B5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E750C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF81549FE58]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF81549FE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
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
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154B5710]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E450C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF8154948B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF8154948E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815496010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+188]
        mov       rcx,rbx
-       call      qword ptr [7FF814E450C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
+       call      qword ptr [7FF814E550C8]; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        mov       r8d,eax
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
-       call      qword ptr [7FF8154948B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,28
        pop       rbx
        pop       rsi
-       jmp       qword ptr [7FF8154948E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 64
 ; DotNetTips.Spargine.Benchmarking.SmallCollectionsBenchmark.get_Count()
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        mov       [rbp+10],rcx
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rax,[rbp+10]
        mov       eax,[rax+184]
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 46
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
        xor       ecx,ecx
        mov       [rbp-8],ecx
        nop
        jmp       short M02_L02
 M02_L01:
        nop
        mov       rcx,[rbp+18]
-       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
        mov       [rbp-0C],eax
        mov       eax,[rbp-0C]
        cmp       eax,[rbp+20]
        sete      al
        movzx     eax,al
        mov       [rbp-8],eax
        nop
 M02_L02:
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 112
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M03_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M03_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815496010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff

```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,18C2380AC30
+       mov       r8,23F0EC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153867D8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8153ADAB8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815386808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153ADAE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18C2380AC28
+       mov       rdx,23F0EC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18C2380AC30
+       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,23F0EC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536D9A0
+       mov       rdx,7FF81538F698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF815386820]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8153ADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F398],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153AF378]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        sub       rsp,28
        vzeroupper
        mov       rcx,[rdx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF814F76E98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
+       call      qword ptr [7FF814F977C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815400198]
+       vdivsd    xmm0,xmm0,[7FF815440258]
        xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154001A0]
+       vucomisd  xmm0,qword ptr [7FF815440260]
        seta      al
        add       rsp,28
        ret
 ; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M04_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M04_L00:
-       call      qword ptr [7FF814AD41F8]
+       call      qword ptr [7FF814AF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,18C2380AC30
+       mov       r8,1EC8000AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153867D8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81538E010]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815386808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81538E040]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18C2380AC28
+       mov       rdx,1EC8000AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18C2380AC30
+       mov       rcx,1EC8000AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
        cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536D9A0
+       mov       rdx,7FF81536F698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF815386820]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81538E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F398],0
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
-       call      qword ptr [7FF81538C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81538F8D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        sub       rsp,28
        vzeroupper
        mov       rcx,[rdx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF814F76E98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
+       call      qword ptr [7FF814F777C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815400198]
+       vdivsd    xmm0,xmm0,[7FF8154220B8]
        xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154001A0]
+       vucomisd  xmm0,qword ptr [7FF8154220C0]
        seta      al
        add       rsp,28
        ret
 ; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M04_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,18C2380AC30
+       mov       r8,1F0E240AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153867D8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF815444960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815386808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815444990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18C2380AC28
+       mov       rdx,1F0E240AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18C2380AC30
+       mov       r8,7FF815440858
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1F0E240AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536D9A0
+       mov       rdx,7FF81538F1A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF815386820]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154449A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F398],0
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
-       call      qword ptr [7FF81538C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815446220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F76E98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815400198]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154001A0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,18C2380AC30
+       mov       r8,1653040AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153867D8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546ED60]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815386808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81546ED90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18C2380AC28
+       mov       rdx,1653040AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18C2380AC30
+       mov       r8,7FF81546AC58
+       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1653040AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536D9A0
+       mov       rdx,7FF81544DB30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF815386820]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546EDA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F398],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F76E98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815400198]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154001A0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AB41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,18C2380AC30
+       mov       r8,1E81C80AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153867D8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815386808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18C2380AC28
+       mov       rdx,1E81C80AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18C2380AC30
+       mov       r8,7FF8154A0858
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E81C80AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536D9A0
+       mov       rdx,7FF81546DF68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF815386820]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F398],0
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
-       call      qword ptr [7FF81538C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F76E98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815400198]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154001A0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,18C2380AC30
+       mov       r8,14C09C0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153867D8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815386808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154D4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18C2380AC28
+       mov       rdx,14C09C0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18C2380AC30
+       mov       r8,7FF8154D0858
+       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,14C09C0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536D9A0
+       mov       rdx,7FF81549E118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF815386820]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F398],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F76E98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815400198]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154001A0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,18C2380AC30
+       mov       r8,24C2AC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153867D8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815386808]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,18C2380AC28
+       mov       rdx,24C2AC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
+       mov       r8,7FF8154B0858
        call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,18C2380AC30
+       mov       rcx,24C2AC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
        cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536D9A0
+       mov       rdx,7FF81548C9C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF815386820]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F398],0
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
-       call      qword ptr [7FF81538C2E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F76E98]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815400198]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154001A0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
+M03_L00:
        call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,23F0EC0AC30
+       mov       r8,1EC8000AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153ADAB8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81538E010]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8153ADAE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81538E040]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23F0EC0AC28
+       mov       rdx,1EC8000AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F0EC0AC30
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1EC8000AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F698
+       mov       rdx,7FF81536F698
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8153ADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81538E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF378]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81538F8D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
        sub       rsp,28
        vzeroupper
        mov       rcx,[rdx+8]
        cmp       [rcx],ecx
-       call      qword ptr [7FF814F977C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
+       call      qword ptr [7FF814F777C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
        vxorps    xmm0,xmm0,xmm0
        vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815440258]
+       vdivsd    xmm0,xmm0,[7FF8154220B8]
        xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF815440260]
+       vucomisd  xmm0,qword ptr [7FF8154220C0]
        seta      al
        add       rsp,28
        ret
 ; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
        je        short M04_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 M04_L00:
-       call      qword ptr [7FF814AF41F8]
+       call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,23F0EC0AC30
+       mov       r8,1F0E240AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153ADAB8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF815444960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8153ADAE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815444990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23F0EC0AC28
+       mov       rdx,1F0E240AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F0EC0AC30
+       mov       r8,7FF815440858
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1F0E240AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F698
+       mov       rdx,7FF81538F1A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8153ADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154449A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF378]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815446220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F977C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815440258]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF815440260]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AF41F8]
+M03_L00:
+       call      qword ptr [7FF814AC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,23F0EC0AC30
+       mov       r8,1653040AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153ADAB8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546ED60]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8153ADAE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81546ED90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23F0EC0AC28
+       mov       rdx,1653040AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F0EC0AC30
+       mov       r8,7FF81546AC58
+       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1653040AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F698
+       mov       rdx,7FF81544DB30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8153ADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546EDA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF378]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F977C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815440258]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF815440260]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AF41F8]
+M03_L00:
+       call      qword ptr [7FF814AB41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,23F0EC0AC30
+       mov       r8,1E81C80AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153ADAB8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8153ADAE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23F0EC0AC28
+       mov       rdx,1E81C80AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F0EC0AC30
+       mov       r8,7FF8154A0858
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E81C80AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F698
+       mov       rdx,7FF81546DF68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8153ADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF378]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F977C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815440258]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF815440260]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AF41F8]
+M03_L00:
+       call      qword ptr [7FF814AC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,23F0EC0AC30
+       mov       r8,14C09C0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153ADAB8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8153ADAE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154D4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23F0EC0AC28
+       mov       rdx,14C09C0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
+       mov       r8,7FF8154D0858
        call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F0EC0AC30
+       mov       rcx,14C09C0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
        cmp       dword ptr [7FF814F8DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F698
+       mov       rdx,7FF81549E118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8153ADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 202
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
-       call      qword ptr [7FF8153AF378]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F977C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815440258]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF815440260]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
+M03_L00:
        call      qword ptr [7FF814AF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,23F0EC0AC30
+       mov       r8,24C2AC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8153ADAB8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8153ADAE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,23F0EC0AC28
+       mov       rdx,24C2AC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,23F0EC0AC30
+       mov       r8,7FF8154B0858
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24C2AC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F698
+       mov       rdx,7FF81548C9C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8153ADB00]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF378]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F977C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF815440258]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF815440260]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AF41F8]
+M03_L00:
+       call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1EC8000AC30
+       mov       r8,1F0E240AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81538E010]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF815444960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81538E040]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815444990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EC8000AC28
+       mov       rdx,1F0E240AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EC8000AC30
+       mov       r8,7FF815440858
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1F0E240AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536F698
+       mov       rdx,7FF81538F1A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154449A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538F8D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815446220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F777C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF8154220B8]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154220C0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1EC8000AC30
+       mov       r8,1653040AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81538E010]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546ED60]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81538E040]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81546ED90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EC8000AC28
+       mov       rdx,1653040AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EC8000AC30
+       mov       r8,7FF81546AC58
+       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1653040AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536F698
+       mov       rdx,7FF81544DB30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546EDA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538F8D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F777C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF8154220B8]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154220C0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AB41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1EC8000AC30
+       mov       r8,1E81C80AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81538E010]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81538E040]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EC8000AC28
+       mov       rdx,1E81C80AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EC8000AC30
+       mov       r8,7FF8154A0858
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E81C80AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536F698
+       mov       rdx,7FF81546DF68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538F8D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F777C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF8154220B8]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154220C0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1EC8000AC30
+       mov       r8,14C09C0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81538E010]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81538E040]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154D4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EC8000AC28
+       mov       rdx,14C09C0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EC8000AC30
+       mov       r8,7FF8154D0858
+       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,14C09C0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536F698
+       mov       rdx,7FF81549E118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538F8D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F777C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF8154220B8]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154220C0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
-       call      qword ptr [7FF814AD41F8]
+M03_L00:
+       call      qword ptr [7FF814AF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1EC8000AC30
+       mov       r8,24C2AC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81538E010]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81538E040]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EC8000AC28
+       mov       rdx,24C2AC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
+       mov       r8,7FF8154B0858
        call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1EC8000AC30
+       mov       rcx,24C2AC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
        cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81536F698
+       mov       rdx,7FF81548C9C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538E058]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 202
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
-       call      qword ptr [7FF81538F8D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       sub       rsp,28
-       vzeroupper
-       mov       rcx,[rdx+8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FF814F777C8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Age()
-       vxorps    xmm0,xmm0,xmm0
-       vcvtsi2sd xmm0,xmm0,rax
-       vdivsd    xmm0,xmm0,[7FF8154220B8]
-       xor       eax,eax
-       vucomisd  xmm0,qword ptr [7FF8154220C0]
-       seta      al
-       add       rsp,28
-       ret
-; Total bytes of code 54
 ; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,r8
        test      rdx,rdx
-       je        short M04_L00
+       je        short M03_L00
        lea       rcx,[rbx+8]
        call      CORINFO_HELP_ASSIGN_REF
        mov       [rbx+18],rsi
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
-M04_L00:
+M03_L00:
        call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1F0E240AC30
+       mov       r8,1653040AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF815444960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546ED60]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815444990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81546ED90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F0E240AC28
+       mov       rdx,1653040AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF815440858
-       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F0E240AC30
+       mov       r8,7FF81546AC58
+       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1653040AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F1A0
+       mov       rdx,7FF81544DB30
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8154449A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF81546EDA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
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
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815446220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815484BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AC41F8]
+       call      qword ptr [7FF814AB41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1F0E240AC30
+       mov       r8,1E81C80AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF815444960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815444990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F0E240AC28
+       mov       rdx,1E81C80AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF815440858
+       mov       r8,7FF8154A0858
        call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F0E240AC30
+       mov       rcx,1E81C80AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
        cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F1A0
+       mov       rdx,7FF81546DF68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8154449A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 202
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
-       call      qword ptr [7FF815446220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1F0E240AC30
+       mov       r8,14C09C0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF815444960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815444990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154D4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F0E240AC28
+       mov       rdx,14C09C0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF815440858
-       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F0E240AC30
+       mov       r8,7FF8154D0858
+       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,14C09C0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F1A0
+       mov       rdx,7FF81549E118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8154449A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
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
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815446220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AC41F8]
+       call      qword ptr [7FF814AF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1F0E240AC30
+       mov       r8,24C2AC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF815444960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815444990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F0E240AC28
+       mov       rdx,24C2AC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF815440858
-       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1F0E240AC30
+       mov       r8,7FF8154B0858
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24C2AC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81538F1A0
+       mov       rdx,7FF81548C9C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8154449A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
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
-       call      qword ptr [7FF815446220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AC41F8]
+       call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1653040AC30
+       mov       r8,1E81C80AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81546ED60]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81546ED90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1653040AC28
+       mov       rdx,1E81C80AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF81546AC58
-       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1653040AC30
+       mov       r8,7FF8154A0858
+       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,1E81C80AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81544DB30
+       mov       rdx,7FF81546DF68
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81546EDA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154A49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AB41F8]
+       call      qword ptr [7FF814AC41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1653040AC30
+       mov       r8,14C09C0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81546ED60]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81546ED90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154D4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1653040AC28
+       mov       rdx,14C09C0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF81546AC58
-       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1653040AC30
+       mov       r8,7FF8154D0858
+       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,14C09C0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81544DB30
+       mov       rdx,7FF81549E118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81546EDA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AB41F8]
+       call      qword ptr [7FF814AF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1653040AC30
+       mov       r8,24C2AC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF81546ED60]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81546ED90]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1653040AC28
+       mov       rdx,24C2AC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF81546AC58
-       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1653040AC30
+       mov       r8,7FF8154B0858
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24C2AC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81544DB30
+       mov       rdx,7FF81548C9C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81546EDA8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815484BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AB41F8]
+       call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1E81C80AC30
+       mov       r8,14C09C0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8154A4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154D4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E81C80AC28
+       mov       rdx,14C09C0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF8154A0858
-       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E81C80AC30
+       mov       r8,7FF8154D0858
+       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,14C09C0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81546DF68
+       mov       rdx,7FF81549E118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8154A49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154D49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
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
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154A6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AC41F8]
+       call      qword ptr [7FF814AF41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,1E81C80AC30
+       mov       r8,24C2AC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8154A4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8154A4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1E81C80AC28
+       mov       rdx,24C2AC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF8154A0858
-       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,1E81C80AC30
+       mov       r8,7FF8154B0858
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24C2AC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81546DF68
+       mov       rdx,7FF81548C9C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8154A49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
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
-       call      qword ptr [7FF8154A6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AC41F8]
+       call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for HaveItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+188]
-       mov       r8,14C09C0AC30
+       mov       r8,24C2AC0AC30
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>,Boolean>)
-       call      qword ptr [7FF8154D4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B4960]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF8154D4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B4990]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C09C0AC28
+       mov       rdx,24C2AC0AC28
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF8154D0858
-       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
-       mov       rcx,14C09C0AC30
+       mov       r8,7FF8154B0858
+       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
+       mov       rcx,24C2AC0AC30
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+18],0
        je        short M01_L04
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+18]
        mov       [rbp-20],rcx
        jmp       short M01_L05
 M01_L04:
        mov       rcx,[rbp+10]
-       mov       rdx,7FF81549E118
+       mov       rdx,7FF81548C9C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8154D49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
+       call      qword ptr [7FF8154B49A8]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
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
 ; Total bytes of code 202
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154D6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6208]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
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
-       call      qword ptr [7FF814AF41F8]
+       call      qword ptr [7FF814AD41F8]
        int       3
 ; Total bytes of code 44
```
**Diff for DoesNotHaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387E88]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81537DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387EB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81537DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538D728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81537F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387E88]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8153ADF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387EB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153ADF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F9C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538D728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153AF6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387E88]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF815387408]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387EB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815387438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538D728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387E88]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548FB28]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387EB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548FB58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538D728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A52F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387E88]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154B48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387EB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF81538D728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387E88]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387EB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538D728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387E88]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387EB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538D728]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81537DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8153ADF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81537DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153ADF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F8DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F9C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
+       cmp       dword ptr [7FF814E4F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81537F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8153AF6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81537DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF815387408]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81537DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815387438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
        cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81537F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81537DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548FB28]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81537DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548FB58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF81537F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A52F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81537DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154B48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81537DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81537F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81537DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81537DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81537F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81537DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81537DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81537F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153ADF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF815387408]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153ADF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815387438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F9C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153ADF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548FB28]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153ADF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548FB58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F9C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A52F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153ADF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154B48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153ADF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F9C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153ADF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153ADF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F9C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8153ADF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153ADF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F8DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F9C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8153AF6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387408]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548FB28]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548FB58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
        cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A52F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387408]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154B48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387408]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815387408]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815387438]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F67C30]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81538CBE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548FB28]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154B48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548FB58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154B48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF8154A52F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154B6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548FB28]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548FB58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF8154A52F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548FB28]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548FB58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F5DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF8154A52F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154B48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154B48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154B6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154B48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154C48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154B48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154C48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.DoesNotHaveItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154B6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154C6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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

```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff

```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81536DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
+       cmp       dword ptr [7FF814DFF6A0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff

```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548C708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548C738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81548DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548F978]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548F9A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A4708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5E60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81536DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F4DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
+       cmp       dword ptr [7FF814DFF6A0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff

```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548C708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548C738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81548DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548F978]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548F9A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A4708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5E60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F7DC18],0
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
-       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814DFF6A0],0
+       cmp       dword ptr [7FF814E3F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548C708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548C738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814DFF6A0],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81548DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548F978]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548F9A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814DFF6A0],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A4708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814DFF6A0],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5E60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F4DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F5C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814DFF6A0],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548C708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548C738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F6DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81548DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548F978]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548F9A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A4708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5E60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81539DF68]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81539DF98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F7DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F8C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
-       call      qword ptr [7FF81539F6D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548C708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF81548F978]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548C738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81548F9A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81548DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548C708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A4708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548C738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81548DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5E60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548C708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548C738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FF814F6DC18],0
+       cmp       dword ptr [7FF814F5DC18],0
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
-       call      qword ptr [7FF814F7C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FF814F6C900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81548DE78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548F978]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A4708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548F9A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 105
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
-       call      qword ptr [7FF8154A5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A5E60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81548F978]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81548F9A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 105
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
-       call      qword ptr [7FF8154A5128]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HaveItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154A4708]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
+       call      qword ptr [7FF8154A48B8]; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154A4738]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A48E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.SortedDictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.SortedDictionary`2<System.__Canon,System.__Canon>)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-4],eax
        mov       [rbp-8],eax
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FF814F5DC18],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        mov       eax,[rbp-8]
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 105
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
-       call      qword ptr [7FF8154A5E60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A6010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
