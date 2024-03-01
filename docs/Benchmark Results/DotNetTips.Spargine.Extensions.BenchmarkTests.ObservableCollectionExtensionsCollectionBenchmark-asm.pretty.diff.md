## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20240301-013024
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38905830]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE388E5F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388E5F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE388CAF18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905878]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE388E5F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389058F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38905830]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38915F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38915F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE38520A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE388FAF18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905878]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38915F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE383BF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389058F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38915FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38905830]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE3899D3E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE3899D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE38979308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905878]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3899D428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389058F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE3899D4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38905830]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A07AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A07B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE389F67D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905878]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A07B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE389058F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A07BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38905830]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE38A08008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905878]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE389058F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38905830]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE389E6848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905878]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389058F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38905830]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905860]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE389E6BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905878]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389058F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE388E5F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38915F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E5F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38915F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE384F0A88],0
+       cmp       dword ptr [7FFE38520A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388CAF18
+       mov       rdx,7FFE388FAF18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388E5F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38915F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383BF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38915FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE388E5F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE3899D3E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E5F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE3899D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388CAF18
+       mov       rdx,7FFE38979308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388E5F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3899D428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE388E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE3899D4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE388E5F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A07AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E5F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A07B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE384F0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388CAF18
+       mov       rdx,7FFE389F67D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388E5F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A07B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A07BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE388E5F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E5F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE384F0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388CAF18
+       mov       rdx,7FFE38A08008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388E5F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE388E5F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E5F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388CAF18
+       mov       rdx,7FFE389E6848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388E5F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE388E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE388E5F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388E5F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388CAF18
+       mov       rdx,7FFE389E6BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388E5F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE388E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38915F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE3899D3E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38915F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE3899D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388FAF18
+       mov       rdx,7FFE38979308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38915F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE3899D428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE3899D4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38915F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A07AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38915F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A07B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388FAF18
+       mov       rdx,7FFE389F67D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38915F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A07B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A07BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38915F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38915F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388FAF18
+       mov       rdx,7FFE38A08008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38915F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38915F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38915F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388FAF18
+       mov       rdx,7FFE389E6848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38915F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38915F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38915F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388FAF18
+       mov       rdx,7FFE389E6BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38915F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE3899D3E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A07AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE3899D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A07B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE384F0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38979308
+       mov       rdx,7FFE389F67D0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE3899D428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A07B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE3899D4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A07BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE3899D3E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE3899D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE384F0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38979308
+       mov       rdx,7FFE38A08008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE3899D428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE3899D4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE3899D3E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE3899D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38979308
+       mov       rdx,7FFE389E6848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE3899D428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE3899D4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE3899D3E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE3899D410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38979308
+       mov       rdx,7FFE389E6BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE3899D428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE3899D4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38A07AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A07B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389F67D0
+       mov       rdx,7FFE38A08008
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38A07B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
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
-       call      qword ptr [7FFE38A07BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38A07AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A07B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389F67D0
+       mov       rdx,7FFE389E6848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38A07B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A07BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38A07AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A07B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389F67D0
+       mov       rdx,7FFE389E6BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38A07B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A07BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38A08008
+       mov       rdx,7FFE389E6848
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 53
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38A08008
+       mov       rdx,7FFE389E6BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        mov       eax,[rbp+20]
        cdqe
        cmp       [rbp-20],rax
        sete      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 180
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389E6848
+       mov       rdx,7FFE389E6BF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1D67980AC20
+       mov       r8,1C90EC0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38915A28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE388CFEA0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38915A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE388CFED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1D67980AC18
+       mov       rdx,1C90EC0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38064210]
-       mov       rcx,1D67980AC20
+       call      qword ptr [7FFE38044210]
+       mov       rcx,1C90EC0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE38500A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388FAFF8
+       mov       rdx,7FFE388D7918
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388964C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38874DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE388CFF30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        sub       rsp,28
        mov       rcx,rdx
        cmp       [rcx],ecx
-       call      qword ptr [7FFE384FD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FFE384DD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FFE3850DF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FFE384EDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
 ; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1D67980AC20
+       mov       r8,2041C008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38915A28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38915A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38905FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1D67980AC18
+       mov       rdx,2041C008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38064210]
-       mov       rcx,1D67980AC20
+       call      qword ptr [7FFE38054210]
+       mov       rcx,2041C008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388FAFF8
+       mov       rdx,7FFE388EAFF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388964C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE388867A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38906010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        sub       rsp,28
        mov       rcx,rdx
        cmp       [rcx],ecx
-       call      qword ptr [7FFE384FD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FFE384ED050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FFE3850DF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FFE384FDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
 ; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1D67980AC20
+       mov       r8,1EE17C0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38915A28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3898D428]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38915A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE3898D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1D67980AC18
+       mov       rdx,1EE17C0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38064210]
-       mov       rcx,1D67980AC20
+       mov       r8,7FFE389893B0
+       call      qword ptr [7FFE38024210]
+       mov       rcx,1EE17C0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388FAFF8
+       mov       rdx,7FFE389693E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388964C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3886E1D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE3898D4B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384FD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE3850DF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1D67980AC20
+       mov       r8,1F183C0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38915A28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389CFB40]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38915A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389CFB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1D67980AC18
+       mov       rdx,1F183C0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38064210]
-       mov       rcx,1D67980AC20
+       mov       r8,7FFE389CBAC8
+       call      qword ptr [7FFE38044210]
+       mov       rcx,1F183C0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE38500A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388FAFF8
+       mov       rdx,7FFE389D7E20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388964C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38904960]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389CFBD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384FD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE3850DF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1D67980AC20
+       mov       r8,1600780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38915A28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38915A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1D67980AC18
+       mov       rdx,1600780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38064210]
-       mov       rcx,1D67980AC20
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,1600780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388FAFF8
+       mov       rdx,7FFE389D7FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388964C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384FD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE3850DF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1D67980AC20
+       mov       r8,25F00008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38915A28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38915A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1D67980AC18
+       mov       rdx,25F00008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38064210]
-       mov       rcx,1D67980AC20
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,25F00008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388FAFF8
+       mov       rdx,7FFE389D6928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388964C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384FD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE3850DF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1D67980AC20
+       mov       r8,1F4F780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38915A28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38A16CD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38915A58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A16D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1D67980AC18
+       mov       rdx,1F4F780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38064210]
-       mov       rcx,1D67980AC20
+       mov       r8,7FFE38A12C58
+       call      qword ptr [7FFE38054210]
+       mov       rcx,1F4F780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38520A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388FAFF8
+       mov       rdx,7FFE38A07148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388964C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389976F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383BF390],0
+       cmp       dword ptr [7FFE383AF468],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38915AB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A16D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384FD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE3850DF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1C90EC0AC20
+       mov       r8,2041C008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE388CFEA0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE388CFED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38905FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C90EC0AC18
+       mov       rdx,2041C008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1C90EC0AC20
+       call      qword ptr [7FFE38054210]
+       mov       rcx,2041C008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388D7918
+       mov       rdx,7FFE388EAFF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38874DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE388867A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388CFF30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38906010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
 ; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        sub       rsp,28
        mov       rcx,rdx
        cmp       [rcx],ecx
-       call      qword ptr [7FFE384DD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FFE384ED050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FFE384EDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FFE384FDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
 ; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1C90EC0AC20
+       mov       r8,1EE17C0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE388CFEA0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3898D428]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE388CFED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE3898D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C90EC0AC18
+       mov       rdx,1EE17C0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1C90EC0AC20
+       mov       r8,7FFE389893B0
+       call      qword ptr [7FFE38024210]
+       mov       rcx,1EE17C0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388D7918
+       mov       rdx,7FFE389693E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38874DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3886E1D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388CFF30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE3898D4B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384DD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384EDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1C90EC0AC20
+       mov       r8,1F183C0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE388CFEA0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389CFB40]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE388CFED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389CFB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C90EC0AC18
+       mov       rdx,1F183C0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFE389CBAC8
        call      qword ptr [7FFE38044210]
-       mov       rcx,1C90EC0AC20
+       mov       rcx,1F183C0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FFE38500A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
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
-       mov       rdx,7FFE388D7918
+       mov       rdx,7FFE389D7E20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38874DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38904960]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 200
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
-       call      qword ptr [7FFE388CFF30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389CFBD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384DD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384EDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1C90EC0AC20
+       mov       r8,1600780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE388CFEA0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE388CFED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C90EC0AC18
+       mov       rdx,1600780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1C90EC0AC20
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,1600780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388D7918
+       mov       rdx,7FFE389D7FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38874DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388CFF30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384DD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384EDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1C90EC0AC20
+       mov       r8,25F00008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE388CFEA0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE388CFED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C90EC0AC18
+       mov       rdx,25F00008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1C90EC0AC20
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,25F00008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388D7918
+       mov       rdx,7FFE389D6928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38874DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388CFF30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384DD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384EDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1C90EC0AC20
+       mov       r8,1F4F780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE388CFEA0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38A16CD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE388CFED0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A16D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1C90EC0AC18
+       mov       rdx,1F4F780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1C90EC0AC20
+       mov       r8,7FFE38A12C58
+       call      qword ptr [7FFE38054210]
+       mov       rcx,1F4F780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388D7918
+       mov       rdx,7FFE38A07148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38874DB0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389976F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE383AF468],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388CFF30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A16D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384DD050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384EDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2041C008C28
+       mov       r8,1EE17C0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3898D428]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38905FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE3898D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2041C008C20
+       mov       rdx,1EE17C0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38054210]
-       mov       rcx,2041C008C28
+       mov       r8,7FFE389893B0
+       call      qword ptr [7FFE38024210]
+       mov       rcx,1EE17C0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388EAFF8
+       mov       rdx,7FFE389693E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388867A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3886E1D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38906010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE3898D4B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384ED050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384FDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2041C008C28
+       mov       r8,1F183C0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389CFB40]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38905FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389CFB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2041C008C20
+       mov       rdx,1F183C0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38054210]
-       mov       rcx,2041C008C28
+       mov       r8,7FFE389CBAC8
+       call      qword ptr [7FFE38044210]
+       mov       rcx,1F183C0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE38500A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388EAFF8
+       mov       rdx,7FFE389D7E20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388867A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38904960]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38906010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389CFBD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384ED050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384FDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2041C008C28
+       mov       r8,1600780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38905FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2041C008C20
+       mov       rdx,1600780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38054210]
-       mov       rcx,2041C008C28
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,1600780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388EAFF8
+       mov       rdx,7FFE389D7FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388867A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38906010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384ED050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384FDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2041C008C28
+       mov       r8,25F00008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38905FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2041C008C20
+       mov       rdx,25F00008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FFE38054210]
-       mov       rcx,2041C008C28
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,25F00008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE388EAFF8
+       mov       rdx,7FFE389D6928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388867A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38906010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384ED050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384FDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,2041C008C28
+       mov       r8,1F4F780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38A16CD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE38905FB0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A16D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2041C008C20
+       mov       rdx,1F4F780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FFE38A12C58
        call      qword ptr [7FFE38054210]
-       mov       rcx,2041C008C28
+       mov       rcx,1F4F780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
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
-       mov       rdx,7FFE388EAFF8
+       mov       rdx,7FFE38A07148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE388867A8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389976F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE383AF468],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38906010]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A16D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
-; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       sub       rsp,28
-       mov       rcx,rdx
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE384ED050]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FFE384FDF50]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
-; Total bytes of code 28
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1EE17C0AC20
+       mov       r8,1F183C0AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE3898D428]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389CFB40]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE3898D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389CFB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EE17C0AC18
+       mov       rdx,1F183C0AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389893B0
-       call      qword ptr [7FFE38024210]
-       mov       rcx,1EE17C0AC20
+       mov       r8,7FFE389CBAC8
+       call      qword ptr [7FFE38044210]
+       mov       rcx,1F183C0AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE384E0A88],0
+       cmp       dword ptr [7FFE38500A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE389693E8
+       mov       rdx,7FFE389D7E20
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE3886E1D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38904960]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE3839F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE3898D4B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389CFBD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1EE17C0AC20
+       mov       r8,1600780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE3898D428]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE3898D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EE17C0AC18
+       mov       rdx,1600780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389893B0
+       mov       r8,7FFE389E3FD8
        call      qword ptr [7FFE38024210]
-       mov       rcx,1EE17C0AC20
+       mov       rcx,1600780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
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
-       mov       rdx,7FFE389693E8
+       mov       rdx,7FFE389D7FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE3886E1D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 200
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
-       call      qword ptr [7FFE3898D4B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1EE17C0AC20
+       mov       r8,25F00008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE3898D428]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE3898D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EE17C0AC18
+       mov       rdx,25F00008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389893B0
+       mov       r8,7FFE389E3FD8
        call      qword ptr [7FFE38024210]
-       mov       rcx,1EE17C0AC20
+       mov       rcx,25F00008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
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
-       mov       rdx,7FFE389693E8
+       mov       rdx,7FFE389D6928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE3886E1D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,50
        pop       rbp
        ret
 ; Total bytes of code 200
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
-       call      qword ptr [7FFE3898D4B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1EE17C0AC20
+       mov       r8,1F4F780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE3898D428]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38A16CD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE3898D458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A16D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1EE17C0AC18
+       mov       rdx,1F4F780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389893B0
-       call      qword ptr [7FFE38024210]
-       mov       rcx,1EE17C0AC20
+       mov       r8,7FFE38A12C58
+       call      qword ptr [7FFE38054210]
+       mov       rcx,1F4F780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE384E0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE389693E8
+       mov       rdx,7FFE38A07148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE3886E1D8]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389976F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE383AF468],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE3898D4B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A16D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1F183C0AC20
+       mov       r8,1600780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE389CFB40]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE389CFB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F183C0AC18
+       mov       rdx,1600780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389CBAC8
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1F183C0AC20
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,1600780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE389D7E20
+       mov       rdx,7FFE389D7FD8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38904960]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389CFBD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1F183C0AC20
+       mov       r8,25F00008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE389CFB40]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE389CFB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F183C0AC18
+       mov       rdx,25F00008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389CBAC8
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1F183C0AC20
+       mov       r8,7FFE389E3FD8
+       call      qword ptr [7FFE38024210]
+       mov       rcx,25F00008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE389D7E20
+       mov       rdx,7FFE389D6928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38904960]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3837F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389CFBD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1F183C0AC20
+       mov       r8,1F4F780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE389CFB40]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38A16CD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE389CFB70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A16D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F183C0AC18
+       mov       rdx,1F4F780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389CBAC8
-       call      qword ptr [7FFE38044210]
-       mov       rcx,1F183C0AC20
+       mov       r8,7FFE38A12C58
+       call      qword ptr [7FFE38054210]
+       mov       rcx,1F4F780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE389D7E20
+       mov       rdx,7FFE38A07148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE38904960]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389976F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE383AF468],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389CFBD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A16D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1600780AC20
+       mov       r8,25F00008C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
        call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
        jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1600780AC18
+       mov       rdx,25F00008C20
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,7FFE389E3FD8
        call      qword ptr [7FFE38024210]
-       mov       rcx,1600780AC20
+       mov       rcx,25F00008C28
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FFE384E0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
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
-       mov       rdx,7FFE389D7FD8
+       mov       rdx,7FFE389D6928
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,1600780AC20
+       mov       r8,1F4F780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38A16CD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A16D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1600780AC18
+       mov       rdx,1F4F780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389E3FD8
-       call      qword ptr [7FFE38024210]
-       mov       rcx,1600780AC20
+       mov       r8,7FFE38A12C58
+       call      qword ptr [7FFE38054210]
+       mov       rcx,1F4F780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE384E0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE389D7FD8
+       mov       rdx,7FFE38A07148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389976F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE383AF468],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A16D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItemsWithPredicate method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithPredicate()
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rsi,[rbx+180]
-       mov       r8,25F00008C28
+       mov       r8,1F4F780AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FFE389EC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE38A16CD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FFE389EC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A16D00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,25F00008C20
+       mov       rdx,1F4F780AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FFE389E3FD8
-       call      qword ptr [7FFE38024210]
-       mov       rcx,25F00008C28
+       mov       r8,7FFE38A12C58
+       call      qword ptr [7FFE38054210]
+       mov       rcx,1F4F780AC20
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,rdi
        jmp       short M00_L00
 ; Total bytes of code 145
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FFE384E0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
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
-       mov       rdx,7FFE389D6928
+       mov       rdx,7FFE38A07148
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FFE3896D080]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FFE389976F0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3837F390],0
+       cmp       dword ptr [7FFE383AF468],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389EC0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A16D60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE388F5FE0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38904888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F6010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388D93E0
+       mov       rdx,7FFE388EAF00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388F6028]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389048D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3839F438],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F60A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38904948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE388F5FE0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38905F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F6010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38905F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388D93E0
+       mov       rdx,7FFE388EAF18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388F6028]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F60A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38905FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE388F5FE0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38905D88]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F6010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38905DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388D93E0
+       mov       rdx,7FFE388EAD10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388F6028]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38905DD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F60A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38905E48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE388F5FE0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F6010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388D93E0
+       mov       rdx,7FFE389D6838
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388F6028]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F60A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE388F5FE0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F6010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388D93E0
+       mov       rdx,7FFE389E7EF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388F6028]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F60A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE388F5FE0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F6010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388D93E0
+       mov       rdx,7FFE38A068C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388F6028]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F60A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE388F5FE0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE388F6010]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38500A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388D93E0
+       mov       rdx,7FFE389E6C70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE388F6028]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE388F60A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38904888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38905F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38905F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF00
+       mov       rdx,7FFE388EAF18
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389048D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F438],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38905FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38904888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38905D88]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38905DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF00
+       mov       rdx,7FFE388EAD10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389048D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38905DD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F438],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38905E48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38904888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF00
+       mov       rdx,7FFE389D6838
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389048D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F438],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38904888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF00
+       mov       rdx,7FFE389E7EF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389048D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F438],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38904888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF00
+       mov       rdx,7FFE38A068C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389048D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F438],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38904888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389048B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF00
+       mov       rdx,7FFE389E6C70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389048D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3839F438],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38904948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38905D88]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38905DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF18
+       mov       rdx,7FFE388EAD10
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38905DD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
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
-       call      qword ptr [7FFE38905FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38905E48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF18
+       mov       rdx,7FFE389D6838
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38905FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF18
+       mov       rdx,7FFE389E7EF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38905FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF18
+       mov       rdx,7FFE38A068C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
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
-       call      qword ptr [7FFE38905FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAF18
+       mov       rdx,7FFE389E6C70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38905FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905D88]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389E7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE389D6838
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905DD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389E7E70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38905E48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389E7EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905D88]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE389E7EF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905DD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38905E48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905D88]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE38A068C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905DD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
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
-       call      qword ptr [7FFE38905E48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38905D88]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38905DB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE388EAD10
+       mov       rdx,7FFE389E6C70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38905DD0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38905E48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE389E7E28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389D6838
+       mov       rdx,7FFE389E7EF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389E7E70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
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
-       call      qword ptr [7FFE389E7EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE389E7E28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE384F0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389D6838
+       mov       rdx,7FFE38A068C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389E7E70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389E7EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE389E7E28]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389E7E58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389D6838
+       mov       rdx,7FFE389E6C70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389E7E70]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
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
-       call      qword ptr [7FFE389E7EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE384F0A88],0
+       cmp       dword ptr [7FFE38510A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389E7EF8
+       mov       rdx,7FFE38A068C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE3838F390],0
+       cmp       dword ptr [7FFE383AF390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE389FC060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE389FC090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE389E7EF8
+       mov       rdx,7FFE389E6C70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE389FC0A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
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
-       call      qword ptr [7FFE389FC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
**Diff for HasItems method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItems()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+180]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FFE38A1C108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FFE389FC108]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FFE38A1C138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FFE389FC138]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 ; Total bytes of code 47
 ; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-0C],eax
        mov       [rbp-10],eax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       cmp       dword ptr [7FFE38510A88],0
+       cmp       dword ptr [7FFE384F0A88],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        nop
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L02
        mov       rcx,[rbp+10]
        mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-18],rcx
        jmp       short M01_L03
 M01_L02:
        mov       rcx,[rbp+10]
-       mov       rdx,7FFE38A068C8
+       mov       rdx,7FFE389E6C70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE38A1C150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FFE389FC150]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
        mov       [rbp-20],rax
        xor       eax,eax
        mov       eax,eax
        cmp       [rbp-20],rax
        setg      al
        movzx     eax,al
        mov       [rbp-10],eax
        nop
 M01_L04:
        mov       eax,[rbp-10]
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 175
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
        push      rbp
        push      rdi
        sub       rsp,28
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       cmp       dword ptr [7FFE383AF390],0
+       cmp       dword ptr [7FFE3838F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE38A1C1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FFE389FC1C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
