## DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark-20240225-043010
**Diff for HasItemsWithCount method between:**
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
.NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark.HasItemsWithCount()
        push      rbx
        sub       rsp,20
        mov       rbx,rcx
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815384888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153848B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815376178
+       mov       rdx,7FF815366188
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F410],0
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815384948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8153846D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815384708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815376178
+       mov       rdx,7FF815365EF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815384720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F410],0
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815384798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815384060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815384090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815376178
+       mov       rdx,7FF815367DC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8153840A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F410],0
+       cmp       dword ptr [7FF814E1F388],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815384120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815455F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815455F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815376178
+       mov       rdx,7FF8154450C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815455F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F410],0
+       cmp       dword ptr [7FF814E0F390],0
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815455FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154673D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815467408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815376178
+       mov       rdx,7FF815455030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815467420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F410],0
+       cmp       dword ptr [7FF814E0F390],0
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154A4D50]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4D80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815376178
+       mov       rdx,7FF8154850C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8154A4D98]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F410],0
+       cmp       dword ptr [7FF814E2F3D0],0
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A4E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815376178
+       mov       rdx,7FF815475030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F410],0
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8153846D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153848B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815384708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815366188
+       mov       rdx,7FF815365EF8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815384720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815384948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815384798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815384060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153848B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815384090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815366188
+       mov       rdx,7FF815367DC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8153840A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F388],0
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
-       call      qword ptr [7FF815384948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815384120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815455F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153848B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815455F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815366188
+       mov       rdx,7FF8154450C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815455F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815384948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815455FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154673D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153848B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815467408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815366188
+       mov       rdx,7FF815455030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815467420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815384948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154A4D50]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153848B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4D80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815366188
+       mov       rdx,7FF8154850C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8154A4D98]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E2F3D0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815384948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A4E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153848B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815366188
+       mov       rdx,7FF815475030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153848D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815384948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8153846D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815384060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815384090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815365EF8
+       mov       rdx,7FF815367DC8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815384720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8153840A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E1F388],0
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
-       call      qword ptr [7FF815384798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815384120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8153846D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815455F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815455F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815365EF8
+       mov       rdx,7FF8154450C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815384720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815455F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815384798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815455FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8153846D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154673D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815467408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815365EF8
+       mov       rdx,7FF815455030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815384720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815467420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815384798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8153846D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154A4D50]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4D80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815365EF8
+       mov       rdx,7FF8154850C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815384720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8154A4D98]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E2F3D0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815384798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A4E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8153846D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384708]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815365EF8
+       mov       rdx,7FF815475030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815384720]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815384798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF815455F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815455F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815367DC8
+       mov       rdx,7FF8154450C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153840A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815455F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E1F388],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815384120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815455FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154673D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815467408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815367DC8
+       mov       rdx,7FF815455030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153840A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815467420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E1F388],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815384120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154A4D50]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4D80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815367DC8
+       mov       rdx,7FF8154850C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153840A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8154A4D98]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E1F388],0
+       cmp       dword ptr [7FF814E2F3D0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815384120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A4E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815384060]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815384090]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815367DC8
+       mov       rdx,7FF815475030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153840A8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E1F388],0
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
-       call      qword ptr [7FF815384120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815455F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154673D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815455F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815467408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF8154450C0
+       mov       rdx,7FF815455030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815455F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815467420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815455FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815455F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154A4D50]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815455F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4D80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F70A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF8154450C0
+       mov       rdx,7FF8154850C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815455F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8154A4D98]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E2F3D0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815455FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A4E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF815455F38]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815455F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F70A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8154450C0
+       mov       rdx,7FF815475030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815455F80]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815455FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8154673D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154A4D50]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815467408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8154A4D80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F70A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815455030
+       mov       rdx,7FF8154850C0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815467420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8154A4D98]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E2F3D0],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154A4E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8154673D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815467408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F70A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815455030
+       mov       rdx,7FF815475030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815467420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, Int32)
        mov       r8d,5
-       call      qword ptr [7FF8154A4D50]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, Int32)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8154A4D80]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8154850C0
+       mov       rdx,7FF815475030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8154A4D98]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F3D0],0
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
-       call      qword ptr [7FF8154A4E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rsi,[rbx+188]
-       mov       r8,14C0340AC20
+       mov       r8,2026500AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81534ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81536EA78]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81534ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C0340AC18
+       mov       rdx,2026500AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,14C0340AC20
+       call      qword ptr [7FF814AF4210]
+       mov       rcx,2026500AC20
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814FB0A88],0
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
-       mov       rdx,7FF8153644C0
+       mov       rdx,7FF8153844E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8152EFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81534ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536EB08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FF814F8CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FF814F7DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FF814F9DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,14C0340AC20
+       mov       r8,2A6D980AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81534ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8153748D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81534ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815374900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C0340AC18
+       mov       rdx,2A6D980AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,14C0340AC20
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,2A6D980AC20
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153644C0
+       mov       rdx,7FF8153561E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8152F52C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81534ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815374960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FF814F5CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FF814F7DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FF814F6DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,14C0340AC20
+       mov       r8,1F97F00AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81534ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81535ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81534ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C0340AC18
+       mov       rdx,1F97F00AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
        call      qword ptr [7FF814AD4210]
-       mov       rcx,14C0340AC20
+       mov       rcx,1F97F00AC20
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
        cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8153644C0
+       mov       rdx,7FF8153661F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8152CF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81534ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FF814F7DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FF814F7D230]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,14C0340AC20
+       mov       r8,19D74C08C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81534ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81534ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C0340AC18
+       mov       rdx,19D74C08C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,14C0340AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,19D74C08C28
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153644C0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C138]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81534ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,14C0340AC20
+       mov       r8,235B680AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81534ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81534ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C0340AC18
+       mov       rdx,235B680AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,14C0340AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,235B680AC20
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F813D8],0
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
-       mov       rdx,7FF8153644C0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F9A8],0
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
-       call      qword ptr [7FF81534ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,14C0340AC20
+       mov       r8,2B41100AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81534ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81534ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C0340AC18
+       mov       rdx,2B41100AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,14C0340AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,2B41100AC20
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153644C0
+       mov       rdx,7FF8154651A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81534ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,14C0340AC20
+       mov       r8,2384940AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81534ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81534ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,14C0340AC18
+       mov       rdx,2384940AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF8154833A8
        call      qword ptr [7FF814AD4210]
-       mov       rcx,14C0340AC20
+       mov       rcx,2384940AC20
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
        cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8153644C0
+       mov       rdx,7FF8154751A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81541C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81534ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154874B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2026500AC20
+       mov       r8,2A6D980AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81536EA78]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8153748D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81536EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815374900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2026500AC18
+       mov       rdx,2A6D980AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AF4210]
-       mov       rcx,2026500AC20
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,2A6D980AC20
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
-       cmp       dword ptr [7FF814FB0A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153844E0
+       mov       rdx,7FF8153561E0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152EFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8152F52C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81536EB08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815374960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F8CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FF814F5CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FF814F9DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FF814F6DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2026500AC20
+       mov       r8,1F97F00AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81536EA78]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81535ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81536EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2026500AC18
+       mov       rdx,1F97F00AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AF4210]
-       mov       rcx,2026500AC20
+       call      qword ptr [7FF814AD4210]
+       mov       rcx,1F97F00AC20
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
-       cmp       dword ptr [7FF814FB0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8153844E0
+       mov       rdx,7FF8153661F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152EFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8152CF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536EB08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F8CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FF814F9DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FF814F7D230]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2026500AC20
+       mov       r8,19D74C08C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81536EA78]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81536EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2026500AC18
+       mov       rdx,19D74C08C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AF4210]
-       mov       rcx,2026500AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,19D74C08C28
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
-       cmp       dword ptr [7FF814FB0A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153844E0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152EFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C138]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81536EB08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F8CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F9DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2026500AC20
+       mov       r8,235B680AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81536EA78]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81536EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2026500AC18
+       mov       rdx,235B680AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AF4210]
-       mov       rcx,2026500AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,235B680AC20
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
-       cmp       dword ptr [7FF814FB0A88],0
+       cmp       dword ptr [7FF814F813D8],0
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
-       mov       rdx,7FF8153844E0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152EFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E4F390],0
+       cmp       dword ptr [7FF814E0F9A8],0
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
-       call      qword ptr [7FF81536EB08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F8CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F9DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2026500AC20
+       mov       r8,2B41100AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81536EA78]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81536EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2026500AC18
+       mov       rdx,2B41100AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AF4210]
-       mov       rcx,2026500AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,2B41100AC20
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
-       cmp       dword ptr [7FF814FB0A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153844E0
+       mov       rdx,7FF8154651A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152EFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81536EB08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F8CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F9DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2026500AC20
+       mov       r8,2384940AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81536EA78]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81536EAA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2026500AC18
+       mov       rdx,2384940AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AF4210]
-       mov       rcx,2026500AC20
+       mov       r8,7FF8154833A8
+       call      qword ptr [7FF814AD4210]
+       mov       rcx,2384940AC20
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
-       cmp       dword ptr [7FF814FB0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8153844E0
+       mov       rdx,7FF8154751A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152EFB70]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81541C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF81536EB08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154874B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F8CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F9DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2A6D980AC20
+       mov       r8,1F97F00AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF8153748D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81535ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815374900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81535ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A6D980AC18
+       mov       rdx,1F97F00AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AC4210]
-       mov       rcx,2A6D980AC20
+       call      qword ptr [7FF814AD4210]
+       mov       rcx,1F97F00AC20
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8153561E0
+       mov       rdx,7FF8153661F0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152F52C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF8152CF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815374960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81535ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F5CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
+       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
        mov       rcx,rax
        add       rsp,28
-       jmp       qword ptr [7FF814F6DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
+       jmp       qword ptr [7FF814F7D230]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2A6D980AC20
+       mov       r8,19D74C08C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF8153748D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815374900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A6D980AC18
+       mov       rdx,19D74C08C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF8154733A8
        call      qword ptr [7FF814AC4210]
-       mov       rcx,2A6D980AC20
+       mov       rcx,19D74C08C28
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
        cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153561E0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152F52C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C138]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF815374960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F5CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F6DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2A6D980AC20
+       mov       r8,235B680AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF8153748D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815374900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A6D980AC18
+       mov       rdx,235B680AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF8154733A8
        call      qword ptr [7FF814AC4210]
-       mov       rcx,2A6D980AC20
+       mov       rcx,235B680AC20
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F813D8],0
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
-       mov       rdx,7FF8153561E0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152F52C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
        call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815374960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F5CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F6DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2A6D980AC20
+       mov       r8,2B41100AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF8153748D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815374900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A6D980AC18
+       mov       rdx,2B41100AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF8154733A8
        call      qword ptr [7FF814AC4210]
-       mov       rcx,2A6D980AC20
+       mov       rcx,2B41100AC20
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
        cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153561E0
+       mov       rdx,7FF8154651A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152F52C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF815374960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F5CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F6DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,2A6D980AC20
+       mov       r8,2384940AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF8153748D0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815374900]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2A6D980AC18
+       mov       rdx,2384940AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AC4210]
-       mov       rcx,2A6D980AC20
+       mov       r8,7FF8154833A8
+       call      qword ptr [7FF814AD4210]
+       mov       rcx,2384940AC20
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8153561E0
+       mov       rdx,7FF8154751A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152F52C0]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81541C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF815374960]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154874B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F5CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F6DB30]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,1F97F00AC20
+       mov       r8,19D74C08C28
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81535ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81535ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F97F00AC18
+       mov       rdx,19D74C08C20
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,1F97F00AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,19D74C08C28
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153661F0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C138]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E2F390],0
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
-       call      qword ptr [7FF81535ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7D230]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,1F97F00AC20
+       mov       r8,235B680AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81535ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81535ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F97F00AC18
+       mov       rdx,235B680AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,1F97F00AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,235B680AC20
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F813D8],0
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
-       mov       rdx,7FF8153661F0
+       mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F9A8],0
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
-       call      qword ptr [7FF81535ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7D230]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,1F97F00AC20
+       mov       r8,2B41100AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81535ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81535ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F97F00AC18
+       mov       rdx,2B41100AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
-       call      qword ptr [7FF814AD4210]
-       mov       rcx,1F97F00AC20
+       mov       r8,7FF8154733A8
+       call      qword ptr [7FF814AC4210]
+       mov       rcx,2B41100AC20
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8153661F0
+       mov       rdx,7FF8154651A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E2F390],0
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
-       call      qword ptr [7FF81535ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7D230]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,1F97F00AC20
+       mov       r8,2384940AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF81535ECD0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF81535ED00]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,1F97F00AC18
+       mov       rdx,2384940AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.ObservableCollectionExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicate>b__3_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
+       mov       r8,7FF8154833A8
        call      qword ptr [7FF814AD4210]
-       mov       rcx,1F97F00AC20
+       mov       rcx,2384940AC20
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
        cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8153661F0
+       mov       rdx,7FF8154751A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF8152CF888]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81541C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
        cmp       dword ptr [7FF814E2F390],0
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
-       call      qword ptr [7FF81535ED60]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154874B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
-       call      qword ptr [7FF814F6CFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_LastName()
-       mov       rcx,rax
-       add       rsp,28
-       jmp       qword ptr [7FF814F7D230]; DotNetTips.Spargine.Extensions.StringExtensions.IsNotEmpty(System.String)
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
        mov       rsi,[rbx+188]
-       mov       r8,19D74C08C28
+       mov       r8,235B680AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
        call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,19D74C08C20
+       mov       rdx,235B680AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,7FF8154733A8
        call      qword ptr [7FF814AC4210]
-       mov       rcx,19D74C08C28
+       mov       rcx,235B680AC20
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F813D8],0
        je        short M01_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M01_L00:
        mov       rcx,[rbp+10]
        mov       rdx,7FF815465110
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538C138]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F9A8],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
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
        mov       rsi,[rbx+188]
-       mov       r8,19D74C08C28
+       mov       r8,2B41100AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
        call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,19D74C08C20
+       mov       rdx,2B41100AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,7FF8154733A8
        call      qword ptr [7FF814AC4210]
-       mov       rcx,19D74C08C28
+       mov       rcx,2B41100AC20
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
        cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815465110
+       mov       rdx,7FF8154651A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538C138]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       [rbp-24],eax
        mov       eax,[rbp-24]
        movzx     eax,al
        mov       [rbp-10],eax
        nop
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
        mov       rsi,[rbx+188]
-       mov       r8,19D74C08C28
+       mov       r8,2384940AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,19D74C08C20
+       mov       rdx,2384940AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF8154733A8
-       call      qword ptr [7FF814AC4210]
-       mov       rcx,19D74C08C28
+       mov       r8,7FF8154833A8
+       call      qword ptr [7FF814AD4210]
+       mov       rcx,2384940AC20
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815465110
+       mov       rdx,7FF8154751A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538C138]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81541C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154874B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rsi,[rbx+188]
-       mov       r8,235B680AC20
+       mov       r8,2B41100AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
        call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       mov       rdx,235B680AC18
+       mov       rdx,2B41100AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
        mov       r8,7FF8154733A8
        call      qword ptr [7FF814AC4210]
-       mov       rcx,235B680AC20
+       mov       rcx,2B41100AC20
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
-       cmp       dword ptr [7FF814F813D8],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815465110
+       mov       rdx,7FF8154651A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
        call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E0F9A8],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
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
        mov       rsi,[rbx+188]
-       mov       r8,235B680AC20
+       mov       r8,2384940AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,235B680AC18
+       mov       rdx,2384940AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF8154733A8
-       call      qword ptr [7FF814AC4210]
-       mov       rcx,235B680AC20
+       mov       r8,7FF8154833A8
+       call      qword ptr [7FF814AD4210]
+       mov       rcx,2384940AC20
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
-       cmp       dword ptr [7FF814F813D8],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815465110
+       mov       rdx,7FF8154751A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81541C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       cmp       dword ptr [7FF814E0F9A8],0
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
-       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154874B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rsi,[rbx+188]
-       mov       r8,2B41100AC20
+       mov       r8,2384940AC20
        mov       r8,[r8]
        test      r8,r8
        je        short M00_L01
 M00_L00:
        mov       rdx,rsi
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Func`2<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>,Boolean>)
-       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       qword ptr [7FF815477450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487450]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
 M00_L01:
        mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester],[System.Boolean, System.Private.CoreLib]]
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       mov       rdx,2B41100AC18
+       mov       rdx,2384940AC18
        mov       rdx,[rdx]
        mov       rcx,rdi
-       mov       r8,7FF8154733A8
-       call      qword ptr [7FF814AC4210]
-       mov       rcx,2B41100AC20
+       mov       r8,7FF8154833A8
+       call      qword ptr [7FF814AD4210]
+       mov       rcx,2384940AC20
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF8154651A0
+       mov       rdx,7FF8154751A0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-20],rax
 M01_L05:
        mov       rcx,[rbp-20]
        mov       rdx,[rbp+18]
        mov       r8,[rbp+20]
-       call      qword ptr [7FF81538C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
+       call      qword ptr [7FF81541C078]; System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
-       call      qword ptr [7FF8154774B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154874B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815377AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF81536E880]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815377B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81536E8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815358068
+       mov       rdx,7FF815375F70
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815377B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF81536E8C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E3F408],0
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
-       call      qword ptr [7FF815377BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81536E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815377AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815377B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815358068
+       mov       rdx,7FF815376100
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815377B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815377BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815377AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF815396A30]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815377B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815396A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815358068
+       mov       rdx,7FF815377970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815377B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815396A78]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815377BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815396AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815377AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF81545FAF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815377B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81545FB28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815358068
+       mov       rdx,7FF815466338
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815377B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF81545FB40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815377BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81545FBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815377AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154753E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815377B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815358068
+       mov       rdx,7FF815455038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815377B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815475428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E1F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815377BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154754A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815377AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815377B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F80A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815358068
+       mov       rdx,7FF8154768D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815377B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815377BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815377AF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154773D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815377B28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815358068
+       mov       rdx,7FF815465030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815377B40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815377BB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815477498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536E880]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536E8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815375F70
+       mov       rdx,7FF815376100
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81536E8C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F408],0
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
-       call      qword ptr [7FF81536E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536E880]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF815396A30]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536E8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815396A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815375F70
+       mov       rdx,7FF815377970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81536E8C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815396A78]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F408],0
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
-       call      qword ptr [7FF81536E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815396AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536E880]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF81545FAF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536E8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81545FB28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815375F70
+       mov       rdx,7FF815466338
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81536E8C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF81545FB40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F408],0
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
-       call      qword ptr [7FF81536E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81545FBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536E880]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154753E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536E8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815375F70
+       mov       rdx,7FF815455038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81536E8C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815475428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F408],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81536E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154754A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536E880]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536E8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815375F70
+       mov       rdx,7FF8154768D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81536E8C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F408],0
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
-       call      qword ptr [7FF81536E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81536E880]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154773D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81536E8B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815375F70
+       mov       rdx,7FF815465030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81536E8C8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F408],0
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
-       call      qword ptr [7FF81536E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815477498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF815396A30]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815396A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815376100
+       mov       rdx,7FF815377970
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815396A78]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815396AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF81545FAF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81545FB28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815376100
+       mov       rdx,7FF815466338
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF81545FB40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81545FBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154753E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815376100
+       mov       rdx,7FF815455038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815475428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154754A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815376100
+       mov       rdx,7FF8154768D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815394888]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154773D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF8153948B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815376100
+       mov       rdx,7FF815465030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF8153948D0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815394948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815477498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815396A30]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF81545FAF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815396A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF81545FB28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814FA0A88],0
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
-       mov       rdx,7FF815377970
+       mov       rdx,7FF815466338
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815396A78]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF81545FB40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815396AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF81545FBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815396A30]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154753E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815396A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815377970
+       mov       rdx,7FF815455038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815396A78]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815475428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E2F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF815396AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154754A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815396A30]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815396A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
        cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815377970
+       mov       rdx,7FF8154768D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815396A78]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815396AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF815396A30]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154773D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815396A60]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815377970
+       mov       rdx,7FF815465030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815396A78]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815396AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815477498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81545FAF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154753E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81545FB28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815475410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F70A88],0
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
-       mov       rdx,7FF815466338
+       mov       rdx,7FF815455038
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81545FB40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815475428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E3F390],0
+       cmp       dword ptr [7FF814E0F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF81545FBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF8154754A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81545FAF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81545FB28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815466338
+       mov       rdx,7FF8154768D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81545FB40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF81545FBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF81545FAF8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154773D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF81545FB28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814FA0A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815466338
+       mov       rdx,7FF815465030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF81545FB40]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF81545FBB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815477498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154753E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815475410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F70A88],0
+       cmp       dword ptr [7FF814F90A88],0
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
-       mov       rdx,7FF815455038
+       mov       rdx,7FF8154768D8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815475428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E2F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154754A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154753E0]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154773D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815475410]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F70A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF815455038
+       mov       rdx,7FF815465030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815475428]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       cmp       dword ptr [7FF814E0F390],0
+       cmp       dword ptr [7FF814E1F390],0
        je        short M02_L00
        call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
 M02_L00:
        mov       rcx,[rbp+10]
-       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-10],rax
        lea       rdx,[rbp+18]
        mov       rcx,[rbp-10]
        cmp       [rcx],ecx
-       call      qword ptr [7FF8154754A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815477498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
        mov       rdx,[rbx+188]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.ObjectModel.ObservableCollection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
-       call      qword ptr [7FF8154873D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
+       call      qword ptr [7FF8154773D8]; DotNetTips.Spargine.Extensions.ObservableCollectionExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.ObjectModel.ObservableCollection`1<System.__Canon>)
        mov       edx,eax
        mov       rcx,rbx
        add       rsp,20
        pop       rbx
-       jmp       qword ptr [7FF815487408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
+       jmp       qword ptr [7FF815477408]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Boolean, System.Private.CoreLib]](Boolean)
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
-       cmp       dword ptr [7FF814F90A88],0
+       cmp       dword ptr [7FF814F80A88],0
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
-       mov       rdx,7FF8154768D8
+       mov       rdx,7FF815465030
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       [rbp-18],rax
 M01_L03:
        mov       rcx,[rbp-18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FF815487420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
+       call      qword ptr [7FF815477420]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastCount[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
-       call      qword ptr [7FF815487498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
+       call      qword ptr [7FF815477498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
        nop
        nop
        add       rsp,28
        pop       rdi
        pop       rbp
        ret
 ; Total bytes of code 77
```
