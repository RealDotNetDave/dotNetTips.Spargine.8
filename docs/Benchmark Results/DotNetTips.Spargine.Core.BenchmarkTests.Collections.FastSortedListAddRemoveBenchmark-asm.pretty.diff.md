## DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark-20250308-131516
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
        mov       edx,[rdx+2B0]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED849A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE07B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+; 	public new void RemoveAt(int index) => base.RemoveAt(index);
+; 	                                       ^^^^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,20
        sub       rsp,20
        lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
+       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        nop
        add       rsp,20
-       add       rsp,20
-       pop       rbp
        pop       rbp
        ret
-       ret
-; Total bytes of code 74
+; Total bytes of code 37
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE07B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EE1D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
        mov       edx,[rdx+2B0]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED849A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
        call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE07B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+; 	public new void RemoveAt(int index) => base.RemoveAt(index);
+; 	                                       ^^^^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,20
        sub       rsp,20
        lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        nop
-       nop
-       add       rsp,20
        add       rsp,20
        pop       rbp
-       pop       rbp
-       ret
        ret
-; Total bytes of code 74
+; Total bytes of code 37
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E6F45A0]
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE07B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EE0D200]
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED849A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE07B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE07B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E695878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED849A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE07B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE07B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E695878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED849A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE07B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
        call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE07B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6A5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED849A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE07B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE07B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED849A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE07B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE07B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
        mov       edx,[rdx+2B0]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
 ; 	public new void RemoveAt(int index) => base.RemoveAt(index);
 ; 	                                       ^^^^^^^^^^^^^^^^^^^^
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E6F45A0]
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EE0D200]
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E695878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E695878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6A5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D200]
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
+       call      qword ptr [7FFF7E695878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D200]
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
+       call      qword ptr [7FFF7E695878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
        call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
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
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D200]
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
+       call      qword ptr [7FFF7E6A5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D200]
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
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
-       mov       edx,[rdx+2B0]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       rsi,[rbx+298]
+       mov       edx,[rbx+2B0]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D200]
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E695878]
+       call      qword ptr [7FFF7E6A5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E695878]
+       call      qword ptr [7FFF7E6B5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E695878]
+       call      qword ptr [7FFF7E6B5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E695878]
+       call      qword ptr [7FFF7E6A5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E695878]
+       call      qword ptr [7FFF7E6B5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4AD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E695878]
+       call      qword ptr [7FFF7E6B5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6A5878]
+       call      qword ptr [7FFF7E6B5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+298]
        mov       edx,[rbx+2B0]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6A5878]
+       call      qword ptr [7FFF7E6B5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+2A8]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       edx,[rdx+2B8]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED86898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7ED917C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
        push      rdi
        push      rsi
        push      rsi
        push      rbp
        push      rbp
        push      rbx
        push      rbx
        sub       rsp,38
        sub       rsp,38
        mov       [rsp+30],rcx
        mov       [rsp+30],rcx
        mov       rbx,rcx
        mov       rbx,rcx
        mov       esi,edx
        mov       esi,edx
        test      esi,esi
        test      esi,esi
        jl        near ptr M01_L03
        jl        near ptr M01_L03
        mov       r8d,[rbx+30]
        mov       r8d,[rbx+30]
        cmp       esi,r8d
        cmp       esi,r8d
        jge       near ptr M01_L03
        jge       near ptr M01_L03
        dec       r8d
        dec       r8d
        mov       [rbx+30],r8d
        mov       [rbx+30],r8d
        cmp       esi,r8d
        cmp       esi,r8d
        jge       short M01_L00
        jge       short M01_L00
        sub       r8d,esi
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
        mov       rcx,[rbx+8]
        mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
        lea       edx,[rsi+1]
        mov       r9d,esi
        mov       r9d,esi
        call      qword ptr [7FFFE4C78A40]
        call      qword ptr [7FFFE4C78A40]
        mov       r8d,[rbx+30]
        mov       r8d,[rbx+30]
        sub       r8d,esi
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
        lea       edx,[rsi+1]
        mov       r9d,esi
        mov       r9d,esi
        call      qword ptr [7FFFE4C78A40]
        call      qword ptr [7FFFE4C78A40]
        call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
 M01_L04:
        call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
        int       3
        int       3
 ; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E6F45A0]
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EE0D248]
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+2A8]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       edx,[rdx+2B8]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED76898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7ED817C8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EDFD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
+       jl        near ptr M01_L02
+       mov       ecx,[rbx+30]
+       cmp       esi,ecx
+       jge       near ptr M01_L01
+       dec       ecx
+       mov       [rbx+30],ecx
+       cmp       esi,ecx
        jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
+       mov       rcx,7FFF7F07E2A4
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
        mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
        mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
+       mov       rcx,7FFF7F07E2A8
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
+       jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
+       mov       rcx,7FFF7F07E2AC
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       rcx,[rbx+10]
+       movsxd    rax,dword ptr [rbx+30]
+       mov       edx,[rcx+8]
+       cmp       rax,rdx
+       jae       near ptr M01_L03
        xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       mov       [rcx+rax*8+10],rdx
+       mov       rcx,7FFF7F07E2B0
+       call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
-       pop       rsi
        pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,7FFF7F07E2A0
+       call      CORINFO_HELP_COUNTPROFILE32
+M01_L02:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
-       mov       rbp,rax
+       mov       ecx,7CB
+       mov       rdx,7FFF7E685198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
+       call      qword ptr [7FFF7EB07EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E45D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
        int       3
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
+; Total bytes of code 345
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
        ret
-; Total bytes of code 8
+; Total bytes of code 4
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
        call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EDFD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAF7EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAF7EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EDB4AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E695198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB17EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E46D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EDAF9D8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E695198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB17EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E46D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EEF6C10]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAF7EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+2A8]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       edx,[rdx+2B8]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED86898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED76898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED917C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7ED817C8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EDFD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
+       jl        near ptr M01_L02
+       mov       ecx,[rbx+30]
+       cmp       esi,ecx
+       jge       near ptr M01_L01
+       dec       ecx
+       mov       [rbx+30],ecx
+       cmp       esi,ecx
        jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
+       mov       rcx,7FFF7F07E2A4
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
        mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
        mov       rcx,[rbx+10]
        mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-M01_L00:
-       mov       rsi,[rbx]
+       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
+       mov       rcx,7FFF7F07E2A8
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
+       jae       near ptr M01_L03
        xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
        mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
+       mov       rcx,7FFF7F07E2AC
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       rcx,[rbx+10]
+       movsxd    rax,dword ptr [rbx+30]
+       mov       edx,[rcx+8]
+       cmp       rax,rdx
+       jae       near ptr M01_L03
        xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       mov       [rcx+rax*8+10],rdx
+       mov       rcx,7FFF7F07E2B0
+       call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
+       add       rsp,28
        pop       rbx
-       pop       rbx
-       pop       rbp
        pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,7FFF7F07E2A0
+       call      CORINFO_HELP_COUNTPROFILE32
+M01_L02:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E685198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB07EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E45D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
        int       3
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
+; Total bytes of code 345
+; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       mov       eax,[rcx+30]
+       ret
+; Total bytes of code 4
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6F45A0]
+       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D248]
+       call      qword ptr [7FFF7EDFD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED86898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED917C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
-       push      rbx
        push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-M01_L00:
-       mov       rsi,[rbx]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
+       add       rsp,28
        pop       rbx
-       pop       rbx
-       pop       rbp
        pop       rbp
        pop       rsi
-       pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAF7EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED86898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED917C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
-       push      rbx
        push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-M01_L00:
-       mov       rsi,[rbx]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
+       add       rsp,28
        pop       rbx
-       pop       rbx
-       pop       rbp
        pop       rbp
        pop       rsi
-       pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAF7EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED86898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED917C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EDB4AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
-       push      rbx
        push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-M01_L00:
-       mov       rsi,[rbx]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
+       add       rsp,28
        pop       rbx
-       pop       rbx
-       pop       rbp
        pop       rbp
        pop       rsi
-       pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E695198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB17EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E46D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED86898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED917C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EDAF9D8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
-       push      rbx
        push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-M01_L00:
-       mov       rsi,[rbx]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
+       add       rsp,28
        pop       rbx
-       pop       rbx
-       pop       rbp
        pop       rbp
        pop       rsi
-       pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E695198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB17EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E46D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED86898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED917C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EEF6C10]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
-       push      rbx
        push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-M01_L00:
-       mov       rsi,[rbx]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
+       add       rsp,28
        pop       rbx
-       pop       rbx
-       pop       rbp
        pop       rbp
        pop       rsi
-       pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAF7EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[7FFFE4C79730]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6F45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED76898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED817C8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F07E2A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F07E2A8
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
-       mov       rcx,7FFF7F07E2AC
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
-       mov       rcx,7FFF7F07E2B0
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
-       mov       rcx,7FFF7F07E2A0
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
-       mov       rdx,7FFF7E685198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB07EB8]
+       call      qword ptr [7FFF7EAF7EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E45D4A0]
+       call      qword ptr [7FFF7E44D4A0]
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
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
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
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED76898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED817C8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F07E2A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F07E2A8
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
-       mov       rcx,7FFF7F07E2AC
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
-       mov       rcx,7FFF7F07E2B0
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
-       mov       rcx,7FFF7F07E2A0
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
-       mov       rdx,7FFF7E685198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB07EB8]
+       call      qword ptr [7FFF7EAF7EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E45D4A0]
+       call      qword ptr [7FFF7E44D4A0]
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
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
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
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED76898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED817C8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EDB4AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F07E2A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F07E2A8
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
-       mov       rcx,7FFF7F07E2AC
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
-       mov       rcx,7FFF7F07E2B0
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
-       mov       rcx,7FFF7F07E2A0
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
-       mov       rdx,7FFF7E685198
+       mov       rdx,7FFF7E695198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB07EB8]
+       call      qword ptr [7FFF7EB17EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E45D4A0]
+       call      qword ptr [7FFF7E46D4A0]
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
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
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
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED76898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED817C8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EDAF9D8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F07E2A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F07E2A8
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
-       mov       rcx,7FFF7F07E2AC
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
-       mov       rcx,7FFF7F07E2B0
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
-       mov       rcx,7FFF7F07E2A0
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
-       mov       rdx,7FFF7E685198
+       mov       rdx,7FFF7E695198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB07EB8]
+       call      qword ptr [7FFF7EB17EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E45D4A0]
+       call      qword ptr [7FFF7E46D4A0]
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
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
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
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+2A8]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       edx,[rdx+2B8]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED76898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED817C8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EEF6C10]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F07E2A4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F07E2A8
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
-       mov       rcx,7FFF7F07E2AC
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
-       mov       rcx,7FFF7F07E2B0
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
-       mov       rcx,7FFF7F07E2A0
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
-       mov       rdx,7FFF7E685198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB07EB8]
+       call      qword ptr [7FFF7EAF7EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E45D4A0]
+       call      qword ptr [7FFF7E44D4A0]
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
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 345
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
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
-       call      qword ptr [7FFF7E6E45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EDB4AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E695198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAF7EB8]
+       call      qword ptr [7FFF7EB17EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E46D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EDAF9D8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E695198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAF7EB8]
+       call      qword ptr [7FFF7EB17EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E46D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EEF6C10]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EDB4AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E695198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAF7EB8]
+       call      qword ptr [7FFF7EB17EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E46D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EDAF9D8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E695198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAF7EB8]
+       call      qword ptr [7FFF7EB17EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E46D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EEF6C10]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDB4AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EDAF9D8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDB4AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EEF6C10]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E695198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB17EB8]
+       call      qword ptr [7FFF7EAF7EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E46D4A0]
+       call      qword ptr [7FFF7E44D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A8]
        mov       edx,[rbx+2B8]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDAF9D8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EEF6C10]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E695198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB17EB8]
+       call      qword ptr [7FFF7EAF7EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E46D4A0]
+       call      qword ptr [7FFF7E44D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED54888]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFF7ED65C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rdx,[rbp-10]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+280]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED54990]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFF7ED65D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E49D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EDED1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 119
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+; 	public FastSortedList() : this(Comparer<T>.Default)
+; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,40
        sub       rsp,40
        lea       rbp,[rsp+40]
-       lea       rbp,[rsp+40]
-       xor       eax,eax
        xor       eax,eax
        mov       [rbp-18],rax
-       mov       [rbp-18],rax
        mov       [rbp-8],rcx
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
-       mov       [rbp-20],rcx
        mov       rcx,[rbp-20]
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
        mov       rcx,[rcx+30]
        mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
        cmp       qword ptr [rcx+10],0
        je        short M01_L00
-       je        short M01_L00
-       mov       rcx,[rbp-20]
        mov       rcx,[rbp-20]
        mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
        mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-10],rcx
-       mov       [rbp-10],rcx
        jmp       short M01_L01
-       jmp       short M01_L01
-M01_L00:
-       mov       rcx,[rbp-20]
 M01_L00:
        mov       rcx,[rbp-20]
-       mov       rdx,7FFF7ED44F00
-       mov       rdx,7FFF7ED44F00
+       mov       rdx,7FFF7ED46DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
        mov       [rbp-10],rax
 M01_L01:
        mov       rcx,[rbp-10]
-M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E5CE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
        mov       rdx,[rbp-18]
        mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF7ED65C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
        nop
-       nop
-       add       rsp,40
        add       rsp,40
        pop       rbp
-       pop       rbp
        ret
-       ret
-; Total bytes of code 268
+; Total bytes of code 134
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+; 	public new bool Remove([NotNull] T item) => base.Remove(item);
+; 	                                            ^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,20
        sub       rsp,20
        lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       mov       [rbp+18],rdx
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
        mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
+       call      qword ptr [7FFF7E49D798]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        nop
        add       rsp,20
-       add       rsp,20
-       pop       rbp
        pop       rbp
        ret
-       ret
-; Total bytes of code 78
+; Total bytes of code 39
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
-       call      qword ptr [7FFF7E6C45A0]
+       call      qword ptr [7FFF7E6D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B88]
+       call      qword ptr [7FFF7EDED218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED54888]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFF7ED75C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rdx,[rbp-10]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+280]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED54990]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFF7ED75D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E4AD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EDFD1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 119
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+; 	public FastSortedList() : this(Comparer<T>.Default)
+; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,40
        sub       rsp,40
        lea       rbp,[rsp+40]
-       lea       rbp,[rsp+40]
-       xor       eax,eax
        xor       eax,eax
        mov       [rbp-18],rax
-       mov       [rbp-18],rax
        mov       [rbp-8],rcx
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
        mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
        mov       rcx,[rcx]
        mov       [rbp-20],rcx
-       mov       [rbp-20],rcx
        mov       rcx,[rbp-20]
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
        mov       rcx,[rcx+30]
        mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
        cmp       qword ptr [rcx+10],0
        je        short M01_L00
-       je        short M01_L00
-       mov       rcx,[rbp-20]
        mov       rcx,[rbp-20]
        mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
        mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
        mov       rcx,[rcx+10]
        mov       [rbp-10],rcx
-       mov       [rbp-10],rcx
        jmp       short M01_L01
-       jmp       short M01_L01
-M01_L00:
-       mov       rcx,[rbp-20]
 M01_L00:
        mov       rcx,[rbp-20]
-       mov       rdx,7FFF7ED44F00
-       mov       rdx,7FFF7ED44F00
+       mov       rdx,7FFF7ED56DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
        mov       [rbp-10],rax
 M01_L01:
        mov       rcx,[rbp-10]
-M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E5DE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
        mov       rdx,[rbp-18]
        mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF7ED75C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
        nop
-       nop
-       add       rsp,40
        add       rsp,40
        pop       rbp
-       pop       rbp
        ret
-       ret
-; Total bytes of code 268
+; Total bytes of code 134
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+; 	public new bool Remove([NotNull] T item) => base.Remove(item);
+; 	                                            ^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,20
        sub       rsp,20
        lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
-       mov       [rbp+18],rdx
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
        mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
+       call      qword ptr [7FFF7E4AD798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        nop
        add       rsp,20
-       add       rsp,20
-       pop       rbp
        pop       rbp
        ret
-       ret
-; Total bytes of code 78
+; Total bytes of code 39
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
-       call      qword ptr [7FFF7E6C45A0]
+       call      qword ptr [7FFF7E6E45A0]
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B88]
+       call      qword ptr [7FFF7EDFD230]
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED54888]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED54990]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2B224C01FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2B224C01FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EE0D518]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       push      rbp
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
-       cmp       qword ptr [rcx+10],0
-       je        short M01_L00
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
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
-       mov       [rbp-10],rcx
-       jmp       short M01_L01
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFF7ED44F00
-       mov       rdx,7FFF7ED44F00
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp-10]
+       mov       rdx,7FFF7F0A8058
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       nop
-       add       rsp,40
-       add       rsp,40
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 268
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+18],rdx
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 78
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
-       call      qword ptr [7FFF7E6C45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B88]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E6A5B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E6A5908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E6A5938]
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
+       mov       r11,7FFF7E2715F0
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED54888]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED54990]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2D088001FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2D088001FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EDED200]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       push      rbp
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E49D7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
-       cmp       qword ptr [rcx+10],0
-       je        short M01_L00
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
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
-       mov       [rbp-10],rcx
-       jmp       short M01_L01
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFF7ED44F00
-       mov       rdx,7FFF7ED44F00
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp-10]
+       mov       rdx,7FFF7F11A998
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       nop
-       add       rsp,40
-       add       rsp,40
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 268
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+18],rdx
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 78
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
-       call      qword ptr [7FFF7E6C45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B88]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E39FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E685B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E685908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E685938]
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
+       mov       r11,7FFF7E2515F0
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED54888]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED54990]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1DEED401FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1DEED401FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EDEED30]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       push      rbp
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
-       cmp       qword ptr [rcx+10],0
-       je        short M01_L00
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
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
-       mov       [rbp-10],rcx
-       jmp       short M01_L01
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFF7ED44F00
-       mov       rdx,7FFF7ED44F00
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp-10]
+       mov       rdx,7FFF7F162E78
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       nop
-       add       rsp,40
-       add       rsp,40
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 268
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+18],rdx
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 78
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
-       call      qword ptr [7FFF7E6C45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B88]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E695B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E695908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E695938]
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
+       mov       r11,7FFF7E261710
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED54888]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED54990]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1D3C1801FF0
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1D3C1801FC0
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EF0C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       push      rbp
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
-       cmp       qword ptr [rcx+10],0
-       je        short M01_L00
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
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
-       mov       [rbp-10],rcx
-       jmp       short M01_L01
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFF7ED44F00
-       mov       rdx,7FFF7ED44F00
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp-10]
+       mov       rdx,7FFF7F17EB28
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       nop
-       add       rsp,40
-       add       rsp,40
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 268
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+18],rdx
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 78
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
-       call      qword ptr [7FFF7E6C45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B88]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E6A5B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E6A5908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E6A5938]
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
+       mov       r11,7FFF7E271E40
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED54888]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED54990]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2511F402008
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2511F401FE8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EFAD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       push      rbp
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       jmp       short M00_L00
+; Total bytes of code 178
+; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       push      r14
+       push      rdi
+       push      rsi
        push      rbp
-       sub       rsp,40
-       sub       rsp,40
-       lea       rbp,[rsp+40]
-       lea       rbp,[rsp+40]
-       xor       eax,eax
-       xor       eax,eax
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       [rbp-8],rcx
-       mov       [rbp-8],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rcx]
-       mov       rcx,[rcx]
-       mov       [rbp-20],rcx
-       mov       [rbp-20],rcx
-       mov       rcx,[rbp-20]
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       cmp       qword ptr [rcx+10],0
-       cmp       qword ptr [rcx+10],0
-       je        short M01_L00
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
-       mov       rcx,[rbp-20]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+30]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+8]
-       mov       rcx,[rcx+10]
-       mov       rcx,[rcx+10]
-       mov       [rbp-10],rcx
-       mov       [rbp-10],rcx
-       jmp       short M01_L01
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFF7ED44F00
-       mov       rdx,7FFF7ED44F00
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
-       mov       [rbp-10],rax
-M01_L01:
-       mov       rcx,[rbp-10]
+       mov       rdx,7FFF7F181D00
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       call      qword ptr [7FFF7E5BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       call      qword ptr [7FFF7ED548A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       nop
-       add       rsp,40
-       add       rsp,40
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 268
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       [rbp+18],rdx
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       call      qword ptr [7FFF7E48D798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 78
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
-       call      qword ptr [7FFF7E6C45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B88]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E695B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E695908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E695938]
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
+       mov       r11,7FFF7E262068
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED65C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFF7ED75C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rdx,[rbp-10]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+280]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED65D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFF7ED75D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E49D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E4AD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EDFD1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 119
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
 ; 	public FastSortedList() : this(Comparer<T>.Default)
 ; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
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
-       mov       rdx,7FFF7ED46DB8
+       mov       rdx,7FFF7ED56DB8
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       [rbp-10],rax
 M01_L01:
        mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5CE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E5DE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       [rbp-18],rax
        mov       rdx,[rbp-18]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED65C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
+       call      qword ptr [7FFF7ED75C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
        nop
        add       rsp,40
        pop       rbp
        ret
 ; Total bytes of code 134
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
 ; 	public new bool Remove([NotNull] T item) => base.Remove(item);
 ; 	                                            ^^^^^^^^^^^^^^^^^
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       rcx,[rbp+10]
        mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E49D798]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFF7E4AD798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E6E45A0]
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EDFD230]
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED65C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED65D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E49D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2B224C01FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2B224C01FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EE0D518]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED46DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F0A8058
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5CE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED65C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E49D798]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E6A5B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E6A5908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E6A5938]
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
+       mov       r11,7FFF7E2715F0
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED65C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED65D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E49D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2D088001FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2D088001FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EDED200]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E49D7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED46DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F11A998
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5CE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED65C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E49D798]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E39FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E685B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E685908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E685938]
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
+       mov       r11,7FFF7E2515F0
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED65C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED65D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E49D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1DEED401FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1DEED401FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EDEED30]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED46DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F162E78
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5CE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED65C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E49D798]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E695B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E695908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E695938]
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
+       mov       r11,7FFF7E261710
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED65C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED65D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E49D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1D3C1801FF0
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1D3C1801FC0
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EF0C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED46DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F17EB28
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5CE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED65C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E49D798]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E6A5B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E6A5908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E6A5938]
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
+       mov       r11,7FFF7E271E40
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED65C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED65D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E49D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2511F402008
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2511F401FE8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EFAD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED46DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F181D00
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5CE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED65C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E49D798]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E695B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E695908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E695938]
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
+       mov       r11,7FFF7E262068
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED75C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4AD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2B224C01FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2B224C01FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EE0D518]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED56DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F0A8058
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5DE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED75C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E4AD798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E6A5B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E6A5908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E6A5938]
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
+       mov       r11,7FFF7E2715F0
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED75C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4AD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2D088001FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2D088001FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EDED200]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E49D7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED56DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F11A998
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5DE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED75C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E4AD798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E39FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E685B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E685908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E685938]
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
+       mov       r11,7FFF7E2515F0
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED75C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4AD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1DEED401FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1DEED401FB8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EDEED30]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED56DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F162E78
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5DE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED75C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E4AD798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E695B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E695908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E695938]
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
+       mov       r11,7FFF7E261710
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED75C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4AD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1D3C1801FF0
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1D3C1801FC0
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EF0C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED56DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F17EB28
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5DE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED75C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E4AD798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E6A5B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E6A5908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E6A5938]
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
+       mov       r11,7FFF7E271E40
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFF7ED75C20]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75D28]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4AD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDFD1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2511F402008
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2511F401FE8
+       mov       rbp,[rcx]
+       lea       rcx,[rsi+8]
+       mov       rdx,rbp
+       call      CORINFO_HELP_ASSIGN_REF
+       lea       rcx,[rsi+18]
+       mov       rdx,rdi
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       r8,[rbx+280]
+       mov       edx,[rsi+10]
+       mov       [rsp+20],edx
+       mov       rdx,rbp
+       mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
+       xor       r9d,r9d
+       call      qword ptr [7FFF7EFAD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-; 	public FastSortedList() : this(Comparer<T>.Default)
-; 	                          ^^^^^^^^^^^^^^^^^^^^^^^^^
+M00_L01:
+       mov       rcx,rsi
+       mov       edx,eax
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7ED56DB8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-10],rax
+       mov       rdx,7FFF7F181D00
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-10]
-       call      qword ptr [7FFF7E5DE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-18],rax
-       mov       rdx,[rbp-18]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7ED75C38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
-       nop
-       add       rsp,40
-       pop       rbp
-       ret
-; Total bytes of code 134
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-; 	public new bool Remove([NotNull] T item) => base.Remove(item);
-; 	                                            ^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],rdx
-       mov       rcx,[rbp+10]
-       mov       rdx,[rbp+18]
-       call      qword ptr [7FFF7E4AD798]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDFD230]
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFF7E695B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFF7E695908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFF7E695938]
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
+       mov       r11,7FFF7E262068
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,2B224C01FC8
+       mov       rcx,2D088001FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2B224C01FB8
+       mov       rcx,2D088001FB8
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EE0D518]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EDED200]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E49D7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F0A8058
+       mov       rdx,7FFF7F11A998
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E39FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E6A5B18]
+       call      qword ptr [7FFF7E685B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E6A5908]
+       call      qword ptr [7FFF7E685908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E6A5938]
+       call      qword ptr [7FFF7E685938]
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
-       mov       r11,7FFF7E2715F0
+       mov       r11,7FFF7E2515F0
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,2B224C01FC8
+       mov       rcx,1DEED401FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2B224C01FB8
+       mov       rcx,1DEED401FB8
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EE0D518]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EDEED30]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F0A8058
+       mov       rdx,7FFF7F162E78
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E6A5B18]
+       call      qword ptr [7FFF7E695B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E6A5908]
+       call      qword ptr [7FFF7E695908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E6A5938]
+       call      qword ptr [7FFF7E695938]
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
-       mov       r11,7FFF7E2715F0
+       mov       r11,7FFF7E261710
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,2B224C01FC8
+       mov       rcx,1D3C1801FF0
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2B224C01FB8
+       mov       rcx,1D3C1801FC0
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EE0D518]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EF0C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F0A8058
+       mov       rdx,7FFF7F17EB28
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
-       mov       r11,7FFF7E2715F0
+       mov       r11,7FFF7E271E40
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,2B224C01FC8
+       mov       rcx,2511F402008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2B224C01FB8
+       mov       rcx,2511F401FE8
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EE0D518]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EFAD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F0A8058
+       mov       rdx,7FFF7F181D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E6A5B18]
+       call      qword ptr [7FFF7E695B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E6A5908]
+       call      qword ptr [7FFF7E695908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E6A5938]
+       call      qword ptr [7FFF7E695938]
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
-       mov       r11,7FFF7E2715F0
+       mov       r11,7FFF7E262068
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,2D088001FC8
+       mov       rcx,1DEED401FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2D088001FB8
+       mov       rcx,1DEED401FB8
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EDED200]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EDEED30]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E49D7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F11A998
+       mov       rdx,7FFF7F162E78
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E39FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E685B18]
+       call      qword ptr [7FFF7E695B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E685908]
+       call      qword ptr [7FFF7E695908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E685938]
+       call      qword ptr [7FFF7E695938]
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
-       mov       r11,7FFF7E2515F0
+       mov       r11,7FFF7E261710
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,2D088001FC8
+       mov       rcx,1D3C1801FF0
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2D088001FB8
+       mov       rcx,1D3C1801FC0
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EDED200]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EF0C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E49D7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F11A998
+       mov       rdx,7FFF7F17EB28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E39FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E685B18]
+       call      qword ptr [7FFF7E6A5B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E685908]
+       call      qword ptr [7FFF7E6A5908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E685938]
+       call      qword ptr [7FFF7E6A5938]
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
-       mov       r11,7FFF7E2515F0
+       mov       r11,7FFF7E271E40
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,2D088001FC8
+       mov       rcx,2511F402008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2D088001FB8
+       mov       rcx,2511F401FE8
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EDED200]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EFAD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E49D7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F11A998
+       mov       rdx,7FFF7F181D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E39FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E685B18]
+       call      qword ptr [7FFF7E695B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E685908]
+       call      qword ptr [7FFF7E695908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E685938]
+       call      qword ptr [7FFF7E695938]
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
-       mov       r11,7FFF7E2515F0
+       mov       r11,7FFF7E262068
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,1DEED401FC8
+       mov       rcx,1D3C1801FF0
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1DEED401FB8
+       mov       rcx,1D3C1801FC0
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EDEED30]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EF0C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F162E78
+       mov       rdx,7FFF7F17EB28
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E695B18]
+       call      qword ptr [7FFF7E6A5B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E695908]
+       call      qword ptr [7FFF7E6A5908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E695938]
+       call      qword ptr [7FFF7E6A5938]
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
-       mov       r11,7FFF7E261710
+       mov       r11,7FFF7E271E40
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,1DEED401FC8
+       mov       rcx,2511F402008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1DEED401FB8
+       mov       rcx,2511F401FE8
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EDEED30]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EFAD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F162E78
+       mov       rdx,7FFF7F181D00
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
-       mov       r11,7FFF7E261710
+       mov       r11,7FFF7E262068
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
-       mov       rcx,1D3C1801FF0
+       mov       rcx,2511F402008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1D3C1801FC0
+       mov       rcx,2511F401FE8
        mov       rbp,[rcx]
        lea       rcx,[rsi+8]
        mov       rdx,rbp
        call      CORINFO_HELP_ASSIGN_REF
        lea       rcx,[rsi+18]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        mov       r8,[rbx+280]
        mov       edx,[rsi+10]
        mov       [rsp+20],edx
        mov       rdx,rbp
        mov       rcx,offset MD_System.Array.IndexOf[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[], DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>, Int32, Int32)
        xor       r9d,r9d
-       call      qword ptr [7FFF7EF0C1B0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFF7EFAD1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFF7E4BD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4AD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7F17EB28
+       mov       rdx,7FFF7F181D00
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFF7E3BFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFF7E3AFC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFF7E6A5B18]
+       call      qword ptr [7FFF7E695B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFF7E6A5908]
+       call      qword ptr [7FFF7E695908]
        int       3
 M01_L06:
-       call      qword ptr [7FFF7E6A5938]
+       call      qword ptr [7FFF7E695938]
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
-       mov       r11,7FFF7E271E40
+       mov       r11,7FFF7E262068
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
        mov       edx,[rdx+2B4]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7EDA17C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
+       jl        near ptr M01_L02
+       mov       ecx,[rbx+30]
+       cmp       esi,ecx
+       jge       near ptr M01_L01
+       dec       ecx
+       mov       [rbx+30],ecx
+       cmp       esi,ecx
        jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
+       mov       rcx,7FFF7F09E53C
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
        mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
        mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
+       mov       rcx,7FFF7F09E540
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
+       jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
+       mov       rcx,7FFF7F09E544
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       rcx,[rbx+10]
+       movsxd    rax,dword ptr [rbx+30]
+       mov       edx,[rcx+8]
+       cmp       rax,rdx
+       jae       near ptr M01_L03
        xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       mov       [rcx+rax*8+10],rdx
+       mov       rcx,7FFF7F09E548
+       call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
-       pop       rsi
        pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,7FFF7F09E538
+       call      CORINFO_HELP_COUNTPROFILE32
+M01_L02:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
-       mov       rbp,rax
+       mov       ecx,7CB
+       mov       rdx,7FFF7E6A5198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
+       call      qword ptr [7FFF7EB27EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       r8,rdi
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E47D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
        int       3
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
+; Total bytes of code 345
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]
+       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]
+       call      qword ptr [7FFF7EE1D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
        mov       edx,[rdx+2B4]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7ED717C8]
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EDED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        push      rdi
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
-       test      esi,esi
        test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
+       jl        near ptr M01_L02
+       mov       ecx,[rbx+30]
+       cmp       esi,ecx
+       jge       near ptr M01_L01
+       dec       ecx
+       mov       [rbx+30],ecx
+       cmp       esi,ecx
        jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
+       mov       rcx,7FFF7F06E17C
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
        mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
        sub       r8d,esi
        mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
        mov       r8,rcx
        lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
        mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
-       mov       rcx,[rbx+8]
+       mov       rcx,7FFF7F06E180
+       call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
-       movsxd    rax,dword ptr [rbx+30]
-       mov       edx,[rcx+8]
        mov       edx,[rcx+8]
        cmp       rax,rdx
-       cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
+       jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
+       mov       rcx,7FFF7F06E184
+       call      CORINFO_HELP_COUNTPROFILE32
+       mov       rcx,[rbx+10]
+       movsxd    rax,dword ptr [rbx+30]
+       mov       edx,[rcx+8]
+       cmp       rax,rdx
+       jae       near ptr M01_L03
        xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       mov       [rcx+rax*8+10],rdx
+       mov       rcx,7FFF7F06E188
+       call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
-       pop       rsi
        pop       rsi
        pop       rdi
-       pop       rdi
-       ret
        ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,7FFF7F06E178
+       call      CORINFO_HELP_COUNTPROFILE32
+M01_L02:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
-       mov       rbp,rax
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
+       call      qword ptr [7FFF7EAFC270]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       r8,rdi
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
        int       3
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
+; Total bytes of code 345
 ; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        push      rbp
        sub       rsp,30
        lea       rbp,[rsp+30]
        xor       eax,eax
        mov       [rbp-8],rax
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]
+       call      qword ptr [7FFF7E6D45A0]
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]
+       call      qword ptr [7FFF7EDED248]
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E6A5198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB27EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E47D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED56898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E665198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAEC270]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E43D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED9C4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E6A5198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB27EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E47D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED8FF00]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E675198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EAFC270]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E44D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED75500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED5D3A0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDF7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EF26C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       push      rdi
-       push      rsi
        push      rsi
        push      rbp
-       push      rbp
        push      rbx
-       push      rbx
-       sub       rsp,38
-       sub       rsp,38
-       mov       [rsp+30],rcx
-       mov       [rsp+30],rcx
-       mov       rbx,rcx
+       sub       rsp,28
        mov       rbx,rcx
        mov       esi,edx
-       mov       esi,edx
        test      esi,esi
-       test      esi,esi
-       jl        near ptr M01_L03
-       jl        near ptr M01_L03
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       near ptr M01_L03
-       jge       near ptr M01_L03
-       dec       r8d
-       dec       r8d
-       mov       [rbx+30],r8d
-       mov       [rbx+30],r8d
-       cmp       esi,r8d
-       cmp       esi,r8d
-       jge       short M01_L00
-       jge       short M01_L00
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
-       mov       r8d,[rbx+30]
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       mov       r9d,esi
-       call      qword ptr [7FFFE4C78A40]
-       call      qword ptr [7FFFE4C78A40]
+       jl        short M01_L01
+       mov       eax,[rbx+30]
+       cmp       esi,eax
+       jge       short M01_L01
+       dec       eax
+       mov       [rbx+30],eax
+       cmp       esi,eax
+       jl        near ptr M01_L02
 M01_L00:
-       mov       rsi,[rbx]
-M01_L00:
-       mov       rsi,[rbx]
-       mov       rcx,rsi
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C78690]
-       call      qword ptr [7FFFE4C78690]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D40]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L01
-       je        short M01_L01
        mov       rcx,[rbx+8]
-       mov       rcx,[rbx+8]
-       movsxd    rax,dword ptr [rbx+30]
        movsxd    rax,dword ptr [rbx+30]
+       mov       rdx,rax
+       mov       r8d,[rcx+8]
+       cmp       rdx,r8
+       jae       near ptr M01_L03
+       xor       r8d,r8d
+       mov       [rcx+rdx*8+10],r8
+       mov       rcx,[rbx+10]
        mov       edx,[rcx+8]
-       mov       edx,[rcx+8]
-       cmp       rax,rdx
        cmp       rax,rdx
-       jae       near ptr M01_L04
-       jae       near ptr M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rcx+rax*8+10],rdx
-       mov       [rcx+rax*8+10],rdx
-M01_L01:
-       mov       rcx,rsi
-M01_L01:
-       mov       rcx,rsi
-       call      qword ptr [7FFFE4C786B0]
-       call      qword ptr [7FFFE4C786B0]
-       mov       rcx,rax
-       mov       rcx,rax
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       call      qword ptr [7FFFE4C78D48]; Precode of System.Runtime.CompilerServices.RuntimeHelpers.IsReferenceOrContainsReferences[[System.__Canon, System.Private.CoreLib]]()
-       test      eax,eax
-       test      eax,eax
-       je        short M01_L02
-       je        short M01_L02
-       mov       rax,[rbx+10]
-       mov       rax,[rbx+10]
-       movsxd    rcx,dword ptr [rbx+30]
-       movsxd    rcx,dword ptr [rbx+30]
-       mov       edx,[rax+8]
-       mov       edx,[rax+8]
-       cmp       rcx,rdx
-       cmp       rcx,rdx
-       jae       short M01_L04
-       jae       short M01_L04
-       xor       edx,edx
-       xor       edx,edx
-       mov       [rax+rcx*8+10],rdx
-       mov       [rax+rcx*8+10],rdx
-M01_L02:
-       inc       dword ptr [rbx+34]
-M01_L02:
+       jae       near ptr M01_L03
+       mov       [rcx+rax*8+10],r8
        inc       dword ptr [rbx+34]
-       add       rsp,38
-       add       rsp,38
-       pop       rbx
+       add       rsp,28
        pop       rbx
        pop       rbp
-       pop       rbp
        pop       rsi
-       pop       rsi
-       pop       rdi
        pop       rdi
        ret
-       ret
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-M01_L03:
-       call      qword ptr [7FFFE4C78950]
-       mov       rdi,rax
+M01_L01:
+       mov       rcx,offset MT_System.Int32
+       call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       [rdi+8],esi
-       mov       [rdi+8],esi
-       call      qword ptr [7FFFE4C78EA0]
-       call      qword ptr [7FFFE4C78EA0]
-       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       call      qword ptr [7FFFE4C78940]
-       call      qword ptr [7FFFE4C78940]
+       mov       ecx,7CB
+       mov       rdx,7FFF7E6A5198
+       call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       mov       rbp,rax
-       mov       r8,rdi
+       call      qword ptr [7FFF7EB27EB8]
+       mov       r9,rax
+       mov       rdx,rbp
        mov       r8,rdi
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[System.Collections.Generic.SortedList`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Current()]
-       mov       rdx,[rdx]
-       mov       rdx,[rdx]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       mov       r9,rsi
-       mov       r9,rsi
-       call      qword ptr [7FFFE4C78A98]
-       call      qword ptr [7FFFE4C78A98]
-       mov       rcx,rbp
-       mov       rcx,rbp
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       call      qword ptr [7FFFE4C78278]; CORINFO_HELP_THROW
-       int       3
-       int       3
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-M01_L04:
-       call      qword ptr [7FFFE4C78288]; CORINFO_HELP_RNGCHKFAIL
-       int       3
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E47D4A0]
+       mov       rcx,rsi
+       call      CORINFO_HELP_THROW
+M01_L02:
+       sub       eax,esi
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       near ptr M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 580
-; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+30]
-       mov       eax,[rcx+30]
-       ret
-       ret
-; Total bytes of code 8
-; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       push      rbp
-       sub       rsp,30
-       lea       rbp,[rsp+30]
-       xor       eax,eax
-       mov       [rbp-8],rax
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7E6E45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDF7BA0]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
        mov       edx,[rdx+2B4]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDA17C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7ED717C8]
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EDED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       mov       rcx,7FFF7F09E53C
+       mov       rcx,7FFF7F06E17C
        call      CORINFO_HELP_COUNTPROFILE32
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F09E540
+       mov       rcx,7FFF7F06E180
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFF7F09E544
+       mov       rcx,7FFF7F06E184
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+10]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFF7F09E548
+       mov       rcx,7FFF7F06E188
        call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFF7F09E538
+       mov       rcx,7FFF7F06E178
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
-       mov       rdx,7FFF7E6A5198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB27EB8]
+       call      qword ptr [7FFF7EAFC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E47D4A0]
+       call      qword ptr [7FFF7E44D4A0]
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E6D45A0]
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EDED248]
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
        call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDA17C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       mov       rcx,7FFF7F09E53C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F09E540
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
-       mov       rcx,7FFF7F09E544
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
-       mov       rcx,7FFF7F09E548
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
-       mov       rcx,7FFF7F09E538
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
        mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFF7E47D4A0]
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
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDA17C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED56898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F09E53C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F09E540
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
-       mov       rcx,7FFF7F09E544
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
-       mov       rcx,7FFF7F09E548
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
-       mov       rcx,7FFF7F09E538
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
-       mov       rdx,7FFF7E6A5198
+       mov       rdx,7FFF7E665198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB27EB8]
+       call      qword ptr [7FFF7EAEC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E47D4A0]
+       call      qword ptr [7FFF7E43D4A0]
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
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDA17C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED9C4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F09E53C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F09E540
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
-       mov       rcx,7FFF7F09E544
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
-       mov       rcx,7FFF7F09E548
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
-       mov       rcx,7FFF7F09E538
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
        mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFF7E47D4A0]
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
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDA17C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED8FF00]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F09E53C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F09E540
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
-       mov       rcx,7FFF7F09E544
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
-       mov       rcx,7FFF7F09E548
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
-       mov       rcx,7FFF7F09E538
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
-       mov       rdx,7FFF7E6A5198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB27EB8]
+       call      qword ptr [7FFF7EAFC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E47D4A0]
+       call      qword ptr [7FFF7E44D4A0]
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
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDA17C8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EF26C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F09E53C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F09E540
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
-       mov       rcx,7FFF7F09E544
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
-       mov       rcx,7FFF7F09E548
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
-       mov       rcx,7FFF7F09E538
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
        mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFF7E47D4A0]
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
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D230]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED717C8]
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F06E17C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F06E180
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
-       mov       rcx,7FFF7F06E184
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
-       mov       rcx,7FFF7F06E188
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
-       mov       rcx,7FFF7F06E178
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAFC270]
+       call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E47D4A0]
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
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E6D45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED717C8]
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED56898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F06E17C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F06E180
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
-       mov       rcx,7FFF7F06E184
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
-       mov       rcx,7FFF7F06E188
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
-       mov       rcx,7FFF7F06E178
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E665198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAFC270]
+       call      qword ptr [7FFF7EAEC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E43D4A0]
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
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E6D45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED717C8]
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED9C4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F06E17C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F06E180
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
-       mov       rcx,7FFF7F06E184
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
-       mov       rcx,7FFF7F06E188
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
-       mov       rcx,7FFF7F06E178
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAFC270]
+       call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E47D4A0]
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
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E6D45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED717C8]
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7ED8FF00]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F06E17C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F06E180
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
-       mov       rcx,7FFF7F06E184
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
-       mov       rcx,7FFF7F06E188
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
-       mov       rcx,7FFF7F06E178
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
        mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFF7EAFC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFF7E44D4A0]
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
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E6D45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED66898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED717C8]
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDED1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFF7EF26C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFF7F06E17C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFF7F06E180
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
-       mov       rcx,7FFF7F06E184
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
-       mov       rcx,7FFF7F06E188
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
-       mov       rcx,7FFF7F06E178
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAFC270]
+       call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E47D4A0]
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
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFF7E6D45A0]
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDED248]
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED56898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E6A5198
+       mov       rdx,7FFF7E665198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB27EB8]
+       call      qword ptr [7FFF7EAEC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E47D4A0]
+       call      qword ptr [7FFF7E43D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED9C4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED8FF00]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E6A5198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB27EB8]
+       call      qword ptr [7FFF7EAFC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E47D4A0]
+       call      qword ptr [7FFF7E44D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED96898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EF26C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED56898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED9C4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E665198
+       mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAEC270]
+       call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E43D4A0]
+       call      qword ptr [7FFF7E47D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED56898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED8FF00]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E665198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAEC270]
+       call      qword ptr [7FFF7EAFC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E43D4A0]
+       call      qword ptr [7FFF7E44D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED56898]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EF26C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E665198
+       mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAEC270]
+       call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E43D4A0]
+       call      qword ptr [7FFF7E47D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED9C4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED8FF00]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E6A5198
+       mov       rdx,7FFF7E675198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EB27EB8]
+       call      qword ptr [7FFF7EAFC270]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E47D4A0]
+       call      qword ptr [7FFF7E44D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED9C4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EF26C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+2A0]
        mov       edx,[rbx+2B4]
        mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED8FF00]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7EF26C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFF7E675198
+       mov       rdx,7FFF7E6A5198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFF7EAFC270]
+       call      qword ptr [7FFF7EB27EB8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFF7E44D4A0]
+       call      qword ptr [7FFF7E47D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
        mov       edx,[rdx+2B4]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED549A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE1D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+; 	public new void RemoveAt(int index) => base.RemoveAt(index);
+; 	                                       ^^^^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,20
        sub       rsp,20
        lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
+       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        nop
        add       rsp,20
-       add       rsp,20
-       pop       rbp
        pop       rbp
        ret
-       ret
-; Total bytes of code 74
+; Total bytes of code 37
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
-       call      qword ptr [7FFF7E6C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EE1D200]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
        mov       edx,[rdx+2B4]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED549A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE0D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+; 	public new void RemoveAt(int index) => base.RemoveAt(index);
+; 	                                       ^^^^^^^^^^^^^^^^^^^^
        push      rbp
-       push      rbp
-       sub       rsp,20
        sub       rsp,20
        lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        nop
        add       rsp,20
-       add       rsp,20
-       pop       rbp
        pop       rbp
        ret
-       ret
-; Total bytes of code 74
+; Total bytes of code 37
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
-       call      qword ptr [7FFF7E6C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EE0D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED549A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED549A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E685878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED549A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
        call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
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
-       call      qword ptr [7FFF7E6C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E675878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED549A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6A5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED549A8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E48D6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EDD7B40]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       push      rbp
-       push      rbp
-       sub       rsp,20
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       [rbp+18],edx
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       mov       rcx,[rbp+10]
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       nop
-       add       rsp,20
-       add       rsp,20
-       pop       rbp
-       pop       rbp
-       ret
-       ret
-; Total bytes of code 74
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EDD7B58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E685878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
        mov       edx,[rdx+2B4]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFF7EE0D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 92
 ; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
 ; 	public new void RemoveAt(int index) => base.RemoveAt(index);
 ; 	                                       ^^^^^^^^^^^^^^^^^^^^
        push      rbp
        sub       rsp,20
        lea       rbp,[rsp+20]
        mov       [rbp+10],rcx
        mov       [rbp+18],edx
        mov       rcx,[rbp+10]
        mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D200]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFF7EE0D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D200]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D200]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E685878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D200]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E675878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D200]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6A5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED95D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4CD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE1D1E8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4CD7A8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E7045A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE1D200]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E685878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6B5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E685878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E675878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+290]
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
        call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       nop
-       add       rsp,20
-       pop       rbp
-       ret
-; Total bytes of code 37
-; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       eax,[rcx+10]
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E6A5878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
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
-       mov       edx,[rdx+2B4]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7ED85D40]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7E4BD6E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFF7EE0D1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 92
-; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-; 	public new void RemoveAt(int index) => base.RemoveAt(index);
-; 	                                       ^^^^^^^^^^^^^^^^^^^^
-       push      rbp
-       sub       rsp,20
-       lea       rbp,[rsp+20]
-       mov       [rbp+10],rcx
-       mov       [rbp+18],edx
-       mov       rcx,[rbp+10]
-       mov       edx,[rbp+18]
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       mov       edx,[rbx+2B4]
+       cmp       [rsi],sil
+       mov       rcx,rsi
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6F45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFF7EE0D1E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFF7E685878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6B5878]
+       call      qword ptr [7FFF7E685878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6B5878]
+       call      qword ptr [7FFF7E675878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6B5878]
+       call      qword ptr [7FFF7E6A5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4CD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6B5878]
+       call      qword ptr [7FFF7E685878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E317750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E685878]
+       call      qword ptr [7FFF7E675878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E685878]
+       call      qword ptr [7FFF7E6A5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E675878]
+       call      qword ptr [7FFF7E6A5878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E48D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E675878]
+       call      qword ptr [7FFF7E685878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E2D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
.NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
        push      rsi
        push      rbx
        sub       rsp,28
        mov       rbx,rcx
        mov       rsi,[rbx+290]
        mov       edx,[rbx+2B4]
        cmp       [rsi],sil
        mov       rcx,rsi
-       call      qword ptr [7FFF7E4BD7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFF7E49D7A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFF7E6A5878]
+       call      qword ptr [7FFF7E685878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFF7E307750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFF7E2E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
