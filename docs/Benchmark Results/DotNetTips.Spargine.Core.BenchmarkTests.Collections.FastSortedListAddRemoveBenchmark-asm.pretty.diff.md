## DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark-20250131-144418
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+290]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       edx,[rdx+2A8]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE4EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEC4B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFE5C5ECB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF16490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFE5CF47F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 37
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       eax,[rcx+10]
        ret
 ; Total bytes of code 4
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF164A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFE5CF47F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE4EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF16490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF164A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6CEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE4EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF16490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF164A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE4EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF16490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF164A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6EEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE4EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF16490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF164A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE4EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF16490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF164A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE4EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF16490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF164A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6CEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC4B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5ECB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF47F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF47F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6CEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC4B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5ECB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF47F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF47F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC4B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5ECB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF47F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF47F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6EEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC4B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5ECB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF47F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF47F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC4B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5ECB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF47F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF47F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+290]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2A8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC4B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5ECB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF47F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2A8]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF47F90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6CEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6CEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6CEA60]
+       call      qword ptr [7FFE5C6EEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6CEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6CEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6EEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6CEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6EEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6EEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6EEA60]
+       call      qword ptr [7FFE5C6CEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6CEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2A8]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5CCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6CEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+2A0]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       edx,[rdx+2B0]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC44E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAB090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFE5CE8EF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF46B98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFE5CF17F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        near ptr M01_L02
        mov       ecx,[rbx+30]
        cmp       esi,ecx
        jge       near ptr M01_L01
        dec       ecx
        mov       [rbx+30],ecx
        cmp       esi,ecx
        jge       short M01_L00
-       mov       rcx,7FFE5D25D9C4
+       mov       rcx,7FFE5D2BA69C
        call      CORINFO_HELP_COUNTPROFILE32
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D25D9C8
+       mov       rcx,7FFE5D2BA6A0
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9CC
+       mov       rcx,7FFE5D2BA6A4
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+10]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9D0
+       mov       rcx,7FFE5D2BA6A8
        call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D25D9C0
+       mov       rcx,7FFE5D2BA698
        call      CORINFO_HELP_COUNTPROFILE32
 M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6AA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C57D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 345
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF46BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFE5CF17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC44E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAB090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF46B98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D25D9C4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D25D9C8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9CC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9D0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D25D9C0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6AA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C57D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF46BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC44E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAB090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF46B98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D25D9C4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D25D9C8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9CC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9D0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D25D9C0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF46BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC44E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAB090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF46B98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CE8F8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D25D9C4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D25D9C8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9CC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9D0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D25D9C0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC66448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF46BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC44E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAB090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF46B98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CF16580]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D25D9C4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D25D9C8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9CC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9D0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D25D9C0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6EA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC6C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C5BD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF46BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC44E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAB090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF46B98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEDDE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D25D9C4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D25D9C8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9CC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9D0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D25D9C0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF46BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEC44E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAB090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF46B98]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5D085500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D25D9C4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D25D9C8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9CC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D25D9D0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D25D9C0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C834B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF46BF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
        call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8EF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF17F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2BA69C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2BA6A0
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A4
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A8
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2BA698
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6AA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFE5CC27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C57D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8EF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF17F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2BA69C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2BA6A0
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A4
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A8
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2BA698
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8EF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF17F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CE8F8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2BA69C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2BA6A0
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A4
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A8
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2BA698
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC66448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8EF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF17F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CF16580]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2BA69C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2BA6A0
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A4
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A8
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2BA698
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6EA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC6C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C5BD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8EF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF17F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEDDE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2BA69C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2BA6A0
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A4
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A8
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2BA698
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A0]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B0]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8EF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF17F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5D085500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2BA69C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2BA6A0
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A4
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2BA6A8
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2BA698
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CE8F8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC66448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CF16580]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6EA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC6C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C5BD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEDDE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE95680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D085500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6AA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC27EB8]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C57D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CE8F8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC47EB8]
+       call      qword ptr [7FFE5CC66448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CF16580]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6EA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC47EB8]
+       call      qword ptr [7FFE5CC6C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C5BD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEDDE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC47EB8]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D085500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8F8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CF16580]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6EA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC66448]
+       call      qword ptr [7FFE5CC6C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C5BD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8F8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEDDE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC66448]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE8F8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D085500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC66448]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF16580]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEDDE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6EA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC6C270]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5BD4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF16580]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D085500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6EA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC6C270]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5BD4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C457750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B0]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEDDE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D085500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6BA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC37ED0]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C58D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp-10],rax
        mov       [rbp+10],rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       [rbp-10],rax
        mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE5E8F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFE5CE94A08]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rdx,[rbp-10]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+278]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE5EA00]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE5CE94B10]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5CCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF26490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 119
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        push      rbp
        sub       rsp,40
        lea       rbp,[rsp+40]
        xor       eax,eax
        mov       [rbp-18],rax
        mov       [rbp-8],rcx
        mov       [rbp+10],rcx
        mov       rcx,[rbp+10]
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
        mov       rcx,[rbp-20]
        mov       rcx,[rcx+30]
        mov       rcx,[rcx+8]
        cmp       qword ptr [rcx+10],0
        je        short M01_L00
        mov       rcx,[rbp-20]
        mov       rcx,[rcx+30]
        mov       rcx,[rcx+8]
        mov       rcx,[rcx+10]
        mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
        mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE94E18
+       mov       rdx,7FFE5CE76CE0
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       [rbp-10],rax
 M01_L01:
        mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C7C6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE5E910]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFE5CE94A20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 134
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5CCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFE5C5BCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 39
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       eax,[rcx+10]
        ret
 ; Total bytes of code 4
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C814B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF264D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFE5CF1C1E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE5E8F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE5EA00]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5CCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF26490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2760D805620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2760D805608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF15FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE94E18
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D1A64D8
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE5E910]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5CCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C814B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF264D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6BED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6BEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6BEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C381848
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE5E8F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE5EA00]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5CCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF26490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1B823C05620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1B823C05608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF2C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5CCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE94E18
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D1C6E00
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE5E910]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5CCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C814B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF264D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6CED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6CEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6CEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C391650
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE5E8F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE5EA00]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5CCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF26490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1FE6F805620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1FE6F805608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF47A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE94E18
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D277858
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE5E910]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5CCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C814B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF264D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6EED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6EEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6EEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3B1648
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE5E8F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE5EA00]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5CCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF26490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1C026405620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1C026405608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF764A8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE94E18
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D2A4628
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE5E910]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5CCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C814B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF264D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6EED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6EEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6EEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3B17A0
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE5E8F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE5EA00]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5CCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF26490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,22D53C05650
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,22D53C05628
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5D0447E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE94E18
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D2AECF0
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE5E910]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5CCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C814B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF264D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6EED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6EEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6EEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3B1E98
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE5E8F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE5EA00]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5CCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF26490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,19AC8C03668
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,19AC8C03640
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5D0C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE94E18
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D282618
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7D6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE5E910]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5CCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C814B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF264D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6BED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6BEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6BEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3820A8
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE94A08]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B10]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2760D805620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2760D805608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF15FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE76CE0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D1A64D8
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7C6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE94A20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6BED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6BEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6BEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C381848
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE94A08]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B10]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1B823C05620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1B823C05608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF2C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5CCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE76CE0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D1C6E00
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7C6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE94A20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6CED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6CEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6CEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C391650
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE94A08]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B10]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1FE6F805620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1FE6F805608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF47A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE76CE0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D277858
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7C6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE94A20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6EED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6EEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6EEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3B1648
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE94A08]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B10]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1C026405620
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1C026405608
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5CF764A8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE76CE0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D2A4628
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7C6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE94A20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6EED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6EEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6EEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3B17A0
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE94A08]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B10]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,22D53C05650
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,22D53C05628
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5D0447E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE76CE0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D2AECF0
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7C6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE94A20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6EED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6EEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6EEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3B1E98
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp-10],rax
-       mov       [rbp+10],rcx
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
-       mov       [rbp-10],rax
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5CE94A08]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+278]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B10]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,19AC8C03668
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,19AC8C03640
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+278]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFE5D0C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       test      eax,eax
+       jge       short M00_L01
+M00_L00:
+       mov       ecx,[rsi+10]
+       mov       rax,[rbx+18]
+       mov       [rax+38],ecx
+       add       rsp,28
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
        ret
-; Total bytes of code 119
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
+       push      rbx
+       sub       rsp,30
+       mov       [rsp+28],rcx
+       mov       rsi,rdx
+       mov       rdi,r8
+       mov       ebx,r9d
+       mov       ebp,[rsp+80]
+       test      rsi,rsi
+       je        short M01_L04
+       mov       r14d,[rsi+8]
+       cmp       r14d,ebx
+       jb        short M01_L05
+       mov       edx,r14d
+       sub       edx,ebx
+       cmp       edx,ebp
+       jb        short M01_L06
+       mov       rdx,[rcx+10]
+       mov       rdx,[rdx+20]
+       test      rdx,rdx
        je        short M01_L00
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFE5CE76CE0
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFE5D282618
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFE5C7C6C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CE94A20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 39
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
-       ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       mov       rcx,rax
+       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
+       cmp       [rcx],rax
+       jne       near ptr M01_L13
+       add       ebp,ebx
+       test      rdi,rdi
+       je        short M01_L07
+       cmp       ebx,ebp
+       jl        short M01_L11
+M01_L02:
+       mov       eax,0FFFFFFFF
+M01_L03:
        add       rsp,30
+       pop       rbx
        pop       rbp
+       pop       rsi
+       pop       rdi
+       pop       r14
        ret
-; Total bytes of code 60
+M01_L04:
+       mov       ecx,2
+       call      qword ptr [7FFE5C6BED00]
+       int       3
+M01_L05:
+       call      qword ptr [7FFE5C6BEAF0]
+       int       3
+M01_L06:
+       call      qword ptr [7FFE5C6BEB20]
+       int       3
+M01_L07:
+       mov       eax,ebx
+       jmp       short M01_L10
+M01_L08:
+       cmp       eax,r14d
+       jae       short M01_L14
+       mov       ecx,eax
+       cmp       qword ptr [rsi+rcx*8+10],0
+       jne       short M01_L09
+       jmp       short M01_L03
+M01_L09:
+       inc       eax
+M01_L10:
+       cmp       eax,ebp
+       jl        short M01_L08
+       jmp       short M01_L02
+M01_L11:
+       cmp       ebx,r14d
+       jae       short M01_L14
+       mov       ecx,ebx
+       cmp       qword ptr [rsi+rcx*8+10],0
+       je        short M01_L12
+       mov       ecx,ebx
+       mov       rcx,[rsi+rcx*8+10]
+       mov       rdx,rdi
+       mov       r11,7FFE5C3820A8
+       call      qword ptr [r11]
+       test      eax,eax
+       je        short M01_L12
+       mov       eax,ebx
+       jmp       short M01_L03
+M01_L12:
+       inc       ebx
+       cmp       ebx,ebp
+       jl        short M01_L11
+       jmp       short M01_L02
+M01_L13:
+       mov       [rsp+20],ebp
+       mov       rdx,rsi
+       mov       r8,rdi
+       mov       r9d,ebx
+       mov       rax,[rcx]
+       mov       rax,[rax+48]
+       call      qword ptr [rax]
+       jmp       near ptr M01_L03
+M01_L14:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 287
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,2760D805620
+       mov       rcx,1B823C05620
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2760D805608
+       mov       rcx,1B823C05608
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF15FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5CF2C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5CCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1A64D8
+       mov       rdx,7FFE5D1C6E00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6BED00]
+       call      qword ptr [7FFE5C6CED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6BEAF0]
+       call      qword ptr [7FFE5C6CEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6BEB20]
+       call      qword ptr [7FFE5C6CEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C381848
+       mov       r11,7FFE5C391650
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,2760D805620
+       mov       rcx,1FE6F805620
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2760D805608
+       mov       rcx,1FE6F805608
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF15FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5CF47A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1A64D8
+       mov       rdx,7FFE5D277858
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6BED00]
+       call      qword ptr [7FFE5C6EED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6BEAF0]
+       call      qword ptr [7FFE5C6EEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6BEB20]
+       call      qword ptr [7FFE5C6EEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C381848
+       mov       r11,7FFE5C3B1648
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,2760D805620
+       mov       rcx,1C026405620
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2760D805608
+       mov       rcx,1C026405608
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF15FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5CF764A8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1A64D8
+       mov       rdx,7FFE5D2A4628
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6BED00]
+       call      qword ptr [7FFE5C6EED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6BEAF0]
+       call      qword ptr [7FFE5C6EEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6BEB20]
+       call      qword ptr [7FFE5C6EEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C381848
+       mov       r11,7FFE5C3B17A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,2760D805620
+       mov       rcx,22D53C05650
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2760D805608
+       mov       rcx,22D53C05628
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF15FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0447E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1A64D8
+       mov       rdx,7FFE5D2AECF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6BED00]
+       call      qword ptr [7FFE5C6EED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6BEAF0]
+       call      qword ptr [7FFE5C6EEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6BEB20]
+       call      qword ptr [7FFE5C6EEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C381848
+       mov       r11,7FFE5C3B1E98
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,2760D805620
+       mov       rcx,19AC8C03668
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2760D805608
+       mov       rcx,19AC8C03640
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF15FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1A64D8
+       mov       rdx,7FFE5D282618
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C381848
+       mov       r11,7FFE5C3820A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1B823C05620
+       mov       rcx,1FE6F805620
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1B823C05608
+       mov       rcx,1FE6F805608
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF2C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5CF47A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5CCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1C6E00
+       mov       rdx,7FFE5D277858
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6CED00]
+       call      qword ptr [7FFE5C6EED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6CEAF0]
+       call      qword ptr [7FFE5C6EEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6CEB20]
+       call      qword ptr [7FFE5C6EEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C391650
+       mov       r11,7FFE5C3B1648
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1B823C05620
+       mov       rcx,1C026405620
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1B823C05608
+       mov       rcx,1C026405608
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF2C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5CF764A8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5CCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1C6E00
+       mov       rdx,7FFE5D2A4628
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6CED00]
+       call      qword ptr [7FFE5C6EED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6CEAF0]
+       call      qword ptr [7FFE5C6EEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6CEB20]
+       call      qword ptr [7FFE5C6EEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C391650
+       mov       r11,7FFE5C3B17A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1B823C05620
+       mov       rcx,22D53C05650
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1B823C05608
+       mov       rcx,22D53C05628
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF2C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0447E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5CCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1C6E00
+       mov       rdx,7FFE5D2AECF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6CED00]
+       call      qword ptr [7FFE5C6EED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6CEAF0]
+       call      qword ptr [7FFE5C6EEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6CEB20]
+       call      qword ptr [7FFE5C6EEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C391650
+       mov       r11,7FFE5C3B1E98
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1B823C05620
+       mov       rcx,19AC8C03668
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1B823C05608
+       mov       rcx,19AC8C03640
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF2C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5CCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D1C6E00
+       mov       rdx,7FFE5D282618
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4DFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6CED00]
+       call      qword ptr [7FFE5C6BED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6CEAF0]
+       call      qword ptr [7FFE5C6BEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6CEB20]
+       call      qword ptr [7FFE5C6BEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C391650
+       mov       r11,7FFE5C3820A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1FE6F805620
+       mov       rcx,1C026405620
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1FE6F805608
+       mov       rcx,1C026405608
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF47A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5CF764A8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D277858
+       mov       rdx,7FFE5D2A4628
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C3B1648
+       mov       r11,7FFE5C3B17A0
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1FE6F805620
+       mov       rcx,22D53C05650
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1FE6F805608
+       mov       rcx,22D53C05628
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF47A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0447E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D277858
+       mov       rdx,7FFE5D2AECF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C3B1648
+       mov       r11,7FFE5C3B1E98
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1FE6F805620
+       mov       rcx,19AC8C03668
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1FE6F805608
+       mov       rcx,19AC8C03640
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF47A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D277858
+       mov       rdx,7FFE5D282618
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6EED00]
+       call      qword ptr [7FFE5C6BED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6EEAF0]
+       call      qword ptr [7FFE5C6BEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6EEB20]
+       call      qword ptr [7FFE5C6BEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C3B1648
+       mov       r11,7FFE5C3820A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1C026405620
+       mov       rcx,22D53C05650
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1C026405608
+       mov       rcx,22D53C05628
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF764A8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0447E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D2A4628
+       mov       rdx,7FFE5D2AECF0
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C3B17A0
+       mov       r11,7FFE5C3B1E98
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,1C026405620
+       mov       rcx,19AC8C03668
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1C026405608
+       mov       rcx,19AC8C03640
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5CF764A8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D2A4628
+       mov       rdx,7FFE5D282618
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6EED00]
+       call      qword ptr [7FFE5C6BED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6EEAF0]
+       call      qword ptr [7FFE5C6BEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6EEB20]
+       call      qword ptr [7FFE5C6BEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C3B17A0
+       mov       r11,7FFE5C3820A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.Remove_FastSortedList()
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rcx,22D53C05650
+       mov       rcx,19AC8C03668
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,22D53C05628
+       mov       rcx,19AC8C03640
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+278]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFE5D0447E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFE5D0C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       ecx,[rsi+10]
        mov       rax,[rbx+18]
        mov       [rax+38],ecx
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M00_L01:
        mov       rcx,rsi
        mov       edx,eax
-       call      qword ptr [7FFE5C5ECBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        jmp       short M00_L00
 ; Total bytes of code 178
 ; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        push      r14
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,30
        mov       [rsp+28],rcx
        mov       rsi,rdx
        mov       rdi,r8
        mov       ebx,r9d
        mov       ebp,[rsp+80]
        test      rsi,rsi
        je        short M01_L04
        mov       r14d,[rsi+8]
        cmp       r14d,ebx
        jb        short M01_L05
        mov       edx,r14d
        sub       edx,ebx
        cmp       edx,ebp
        jb        short M01_L06
        mov       rdx,[rcx+10]
        mov       rdx,[rdx+20]
        test      rdx,rdx
        je        short M01_L00
        jmp       short M01_L01
 M01_L00:
-       mov       rdx,7FFE5D2AECF0
+       mov       rdx,7FFE5D282618
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFE5C4FFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFE5C4CFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       rcx,rax
        mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
        cmp       [rcx],rax
        jne       near ptr M01_L13
        add       ebp,ebx
        test      rdi,rdi
        je        short M01_L07
        cmp       ebx,ebp
        jl        short M01_L11
        add       rsp,30
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        pop       r14
        ret
 M01_L04:
        mov       ecx,2
-       call      qword ptr [7FFE5C6EED00]
+       call      qword ptr [7FFE5C6BED00]
        int       3
 M01_L05:
-       call      qword ptr [7FFE5C6EEAF0]
+       call      qword ptr [7FFE5C6BEAF0]
        int       3
 M01_L06:
-       call      qword ptr [7FFE5C6EEB20]
+       call      qword ptr [7FFE5C6BEB20]
        int       3
 M01_L07:
        mov       eax,ebx
        cmp       eax,ebp
        jl        short M01_L08
        jmp       short M01_L02
 M01_L11:
        cmp       ebx,r14d
        jae       short M01_L14
        mov       ecx,ebx
        cmp       qword ptr [rsi+rcx*8+10],0
        je        short M01_L12
        mov       ecx,ebx
        mov       rcx,[rsi+rcx*8+10]
        mov       rdx,rdi
-       mov       r11,7FFE5C3B1E98
+       mov       r11,7FFE5C3820A8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+298]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       edx,[rdx+2AC]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE6F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE9B090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFE5CEAEF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF35FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFE5CF37F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        near ptr M01_L02
        mov       ecx,[rbx+30]
        cmp       esi,ecx
        jge       near ptr M01_L01
        dec       ecx
        mov       [rbx+30],ecx
        cmp       esi,ecx
        jge       short M01_L00
-       mov       rcx,7FFE5D23D92C
+       mov       rcx,7FFE5D2DA7A4
        call      CORINFO_HELP_COUNTPROFILE32
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
        call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
        call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D23D930
+       mov       rcx,7FFE5D2DA7A8
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D934
+       mov       rcx,7FFE5D2DA7AC
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+10]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D938
+       mov       rcx,7FFE5D2DA7B0
        call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D23D928
+       mov       rcx,7FFE5D2DA7A0
        call      CORINFO_HELP_COUNTPROFILE32
 M01_L02:
        mov       rcx,offset MT_System.Int32
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFE5CC4C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 345
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
        call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF36040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFE5CF37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE6F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE9B090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF35FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEA5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D23D92C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D23D930
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D934
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D938
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D23D928
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF36040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE6F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE9B090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF35FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEB4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D23D92C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D23D930
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D934
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D938
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D23D928
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFE5CC4C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF36040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE6F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE9B090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF35FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D23D92C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D23D930
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D934
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D938
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D23D928
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF36040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE6F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE9B090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF35FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CF07288]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D23D92C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D23D930
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D934
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D938
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D23D928
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC57EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF36040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE6F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE9B090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF35FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CFD4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D23D92C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D23D930
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D934
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D938
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D23D928
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF36040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE6F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE9B090]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF35FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5D00EB38]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D23D92C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D23D930
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D934
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D23D938
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D23D928
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC46448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF36040]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAEF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF37F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEA5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2DA7A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2DA7A8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7AC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7B0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2DA7A0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC37ED0]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAEF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF37F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CEB4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2DA7A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2DA7A8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7AC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7B0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2DA7A0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFE5CC4C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
        call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAEF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF37F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2DA7A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2DA7A8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7AC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7B0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2DA7A0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAEF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF37F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CF07288]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2DA7A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2DA7A8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7AC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7B0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2DA7A0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC57EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAEF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF37F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5CFD4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2DA7A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2DA7A8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7AC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7B0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2DA7A0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+298]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2AC]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEAEF18]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF37F78]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFE5D00EB38]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+30]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 92
+; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
        jl        near ptr M01_L02
-       mov       ecx,[rbx+30]
-       cmp       esi,ecx
-       jge       near ptr M01_L01
-       dec       ecx
-       mov       [rbx+30],ecx
-       cmp       esi,ecx
-       jge       short M01_L00
-       mov       rcx,7FFE5D2DA7A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFE5D2DA7A8
-       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7AC
-       call      CORINFO_HELP_COUNTPROFILE32
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
-       movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFE5D2DA7B0
-       call      CORINFO_HELP_COUNTPROFILE32
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFE5D2DA7A0
-       call      CORINFO_HELP_COUNTPROFILE32
-M01_L02:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC46448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-       int       3
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C824B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF37FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEA5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEB4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6BA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC37ED0]
+       call      qword ptr [7FFE5CC4C270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C58D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEA5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6BA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC37ED0]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C58D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEA5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CF07288]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6BA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC37ED0]
+       call      qword ptr [7FFE5CC57EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C58D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEA5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CFD4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6BA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC37ED0]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C58D4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEA5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D00EB38]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC37ED0]
+       call      qword ptr [7FFE5CC46448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CF07288]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC57EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CFD4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
        mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D00EB38]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC4C270]
+       call      qword ptr [7FFE5CC46448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CF07288]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6DA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC47EB8]
+       call      qword ptr [7FFE5CC57EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C5AD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CFD4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CEB5680]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D00EB38]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC47EB8]
+       call      qword ptr [7FFE5CC46448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF07288]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CFD4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6CA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC47EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C59D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF07288]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D00EB38]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6DA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC57EB8]
+       call      qword ptr [7FFE5CC46448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5AD4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2AC]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CFD4C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5D00EB38]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+30]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 50
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
        test      esi,esi
        jl        short M01_L01
        mov       eax,[rbx+30]
        cmp       esi,eax
        jge       short M01_L01
        dec       eax
        mov       [rbx+30],eax
        cmp       esi,eax
        jl        near ptr M01_L02
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       rdx,rax
        mov       r8d,[rcx+8]
        cmp       rdx,r8
        jae       near ptr M01_L03
        xor       r8d,r8d
        mov       [rcx+rdx*8+10],r8
        mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rcx,offset MT_System.Int32
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
        mov       rcx,offset MT_System.ArgumentOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       ecx,7CB
-       mov       rdx,7FFE5C6CA0F8
+       mov       rdx,7FFE5C6BA0F8
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFE5CC47EB8]
+       call      qword ptr [7FFE5CC46448]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFE5C59D4A0]
+       call      qword ptr [7FFE5C58D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C427750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+288]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       edx,[rdx+2AC]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE7F678]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5CE94B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5FCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF56AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5FCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        nop
        add       rsp,20
        pop       rbp
        ret
 ; Total bytes of code 37
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       eax,[rcx+10]
        ret
 ; Total bytes of code 4
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C844B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF56AD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFE5CF1C1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE7F678]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5FCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF56AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5FCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C844B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF56AD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE7F678]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5FCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF56AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5FCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C844B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF56AD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6BEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE7F678]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5FCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF56AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5FCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C844B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF56AD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE7F678]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5FCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF56AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5FCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C844B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF56AD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6BEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE7F678]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5FCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF56AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5FCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C844B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF56AD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6EEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE7F678]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5FCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF56AC0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5FCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C844B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF56AD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6BEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6BEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6EEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+288]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2AC]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CE94B28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5C5BCB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5CF1C198]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFE5C5BCBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+288]
+       mov       edx,[rbx+2AC]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       mov       eax,[rsi+10]
+       mov       rcx,[rbx+18]
+       mov       [rcx+38],eax
+       add       rsp,28
+       pop       rbx
+       pop       rsi
        ret
-; Total bytes of code 4
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
+; Total bytes of code 51
+; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       push      rbx
        sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFE5C804B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFE5CF1C1B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rbx,rcx
+       mov       r9d,edx
+       mov       eax,[rbx+10]
+       cmp       r9d,eax
+       jae       short M01_L01
+       dec       eax
+       mov       [rbx+10],eax
+       cmp       r9d,eax
+       jl        short M01_L02
+M01_L00:
+       mov       rax,[rbx+8]
+       movsxd    rcx,dword ptr [rbx+10]
+       mov       edx,[rax+8]
+       cmp       rcx,rdx
+       jae       short M01_L03
+       xor       edx,edx
+       mov       [rax+rcx*8+10],rdx
+       inc       dword ptr [rbx+14]
        add       rsp,30
-       pop       rbp
+       pop       rbx
        ret
-; Total bytes of code 60
+M01_L01:
+       call      qword ptr [7FFE5C6DEA60]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6BEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6BEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6EEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6BEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6BEA60]
+       call      qword ptr [7FFE5C6EEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6BEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6BEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6DEA60]
+       call      qword ptr [7FFE5C6EEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6BEA60]
+       call      qword ptr [7FFE5C6EEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5BCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6BEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C417750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
.NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+288]
        mov       edx,[rbx+2AC]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFE5C5ECBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFE5C5DCBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       eax,[rsi+10]
        mov       rcx,[rbx+18]
        mov       [rcx+38],eax
        add       rsp,28
        pop       rbx
        pop       rsi
        ret
 ; Total bytes of code 51
 ; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rbx
        sub       rsp,30
        mov       rbx,rcx
        mov       r9d,edx
        mov       eax,[rbx+10]
        cmp       r9d,eax
        jae       short M01_L01
        dec       eax
        mov       [rbx+10],eax
        cmp       r9d,eax
        jl        short M01_L02
        mov       rax,[rbx+8]
        movsxd    rcx,dword ptr [rbx+10]
        mov       edx,[rax+8]
        cmp       rcx,rdx
        jae       short M01_L03
        xor       edx,edx
        mov       [rax+rcx*8+10],rdx
        inc       dword ptr [rbx+14]
        add       rsp,30
        pop       rbx
        ret
 M01_L01:
-       call      qword ptr [7FFE5C6EEA60]
+       call      qword ptr [7FFE5C6DEA60]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFE5C447750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFE5C437750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
