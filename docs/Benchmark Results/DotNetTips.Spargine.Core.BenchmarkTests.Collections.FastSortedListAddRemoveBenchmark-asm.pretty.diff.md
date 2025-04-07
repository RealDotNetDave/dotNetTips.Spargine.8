## DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark-20250406-154752
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B742A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
        call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFC04BE74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
        call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
        call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFC04BE74C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04455878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04475878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04455878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04475878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B742A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE74C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04455878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B742A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE74C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04475878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B742A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE74C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04455878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B742A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE74C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B742A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE74C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04475878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B742A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE74C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04455878]
+       call      qword ptr [7FFC04475878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04455878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04455878]
+       call      qword ptr [7FFC04475878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04455878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04475878]
+       call      qword ptr [7FFC04455878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04475878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04475878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04455878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04455878]
+       call      qword ptr [7FFC04475878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0425D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04455878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04475878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAtFastSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0427D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04475878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B41298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFC04B54408]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFC04BD74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       mov       rcx,7FFC04EE32BC
+       mov       rcx,7FFC04F6E704
        call      CORINFO_HELP_COUNTPROFILE32
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04EE32C0
+       mov       rcx,7FFC04F6E708
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFC04EE32C4
+       mov       rcx,7FFC04F6E70C
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+10]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFC04EE32C8
+       mov       rcx,7FFC04F6E710
        call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFC04EE32B8
+       mov       rcx,7FFC04F6E700
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0422D4A0]
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFC04BD7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B41298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04EE32BC
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04EE32C0
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
-       mov       rcx,7FFC04EE32C4
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
-       mov       rcx,7FFC04EE32C8
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
-       mov       rcx,7FFC04EE32B8
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0422D4A0]
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
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B41298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04EE32BC
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04EE32C0
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
-       mov       rcx,7FFC04EE32C4
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
-       mov       rcx,7FFC04EE32C8
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
-       mov       rcx,7FFC04EE32B8
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04435198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048C60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC041FD4A0]
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
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B41298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04EE32BC
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04EE32C0
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
-       mov       rcx,7FFC04EE32C4
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
-       mov       rcx,7FFC04EE32C8
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
-       mov       rcx,7FFC04EE32B8
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048D6418]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B41298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04EE32BC
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04EE32C0
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
-       mov       rcx,7FFC04EE32C4
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
-       mov       rcx,7FFC04EE32C8
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
-       mov       rcx,7FFC04EE32B8
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B41298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04CAED18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04EE32BC
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04EE32C0
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
-       mov       rcx,7FFC04EE32C4
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
-       mov       rcx,7FFC04EE32C8
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
-       mov       rcx,7FFC04EE32B8
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0422D4A0]
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
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B41298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04D04C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04EE32BC
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04EE32C0
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
-       mov       rcx,7FFC04EE32C4
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
-       mov       rcx,7FFC04EE32C8
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
-       mov       rcx,7FFC04EE32B8
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
        call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B54408]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       mov       rcx,7FFC04F6E704
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F6E708
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
-       mov       rcx,7FFC04F6E70C
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
-       mov       rcx,7FFC04F6E710
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
-       mov       rcx,7FFC04F6E700
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
        mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0422D4A0]
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
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B54408]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F6E704
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F6E708
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
-       mov       rcx,7FFC04F6E70C
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
-       mov       rcx,7FFC04F6E710
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
-       mov       rcx,7FFC04F6E700
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04435198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048C60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC041FD4A0]
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
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B54408]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F6E704
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F6E708
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
-       mov       rcx,7FFC04F6E70C
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
-       mov       rcx,7FFC04F6E710
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
-       mov       rcx,7FFC04F6E700
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048D6418]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B54408]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F6E704
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F6E708
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
-       mov       rcx,7FFC04F6E70C
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
-       mov       rcx,7FFC04F6E710
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
-       mov       rcx,7FFC04F6E700
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B54408]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04CAED18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F6E704
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F6E708
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
-       mov       rcx,7FFC04F6E70C
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
-       mov       rcx,7FFC04F6E710
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
-       mov       rcx,7FFC04F6E700
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
        mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0422D4A0]
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
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A8]
+       mov       edx,[rbx+2B8]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B54408]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04D04C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F6E704
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F6E708
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
-       mov       rcx,7FFC04F6E70C
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
-       mov       rcx,7FFC04F6E710
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
-       mov       rcx,7FFC04F6E700
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04435198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048C60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC041FD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048D6418]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04CAED18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B64DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D04C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04435198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048C60E8]
+       call      qword ptr [7FFC048D6418]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC041FD4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04435198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048C60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC041FD4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04CAED18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04435198
+       mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048C60E8]
+       call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC041FD4A0]
+       call      qword ptr [7FFC0422D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D04C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04435198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048C60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC041FD4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff
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
        mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D6418]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04CAED18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04445198
+       mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D6418]
+       call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0420D4A0]
+       call      qword ptr [7FFC0422D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D04C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
        mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D6418]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04CAED18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04445198
+       mov       rdx,7FFC04465198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D60E8]
+       call      qword ptr [7FFC048F60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0420D4A0]
+       call      qword ptr [7FFC0422D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAtSortedListComparer method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D04C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04CAED18]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D04C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04465198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048F60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0422D4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04AEEA90]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
+       call      qword ptr [7FFC04B74180]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
        mov       rdx,[rbp-10]
        mov       [rbp-8],rdx
        mov       rdx,[rbp+10]
        mov       rdx,[rdx+280]
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04AEEB98]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFC04B74288]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC0424D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-14],eax
        mov       edx,[rbp-14]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BA6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFC04BE7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
        mov       [rbp-10],rax
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
        mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
        mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B168C8
+       mov       rdx,7FFC04B48780
        call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
        mov       [rbp-18],rax
 M01_L01:
        mov       rcx,[rbp-18]
-       call      qword ptr [7FFC0437E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC043BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
        mov       [rbp-10],rax
        lea       rdx,[rbp-10]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04AEEAA8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
+       call      qword ptr [7FFC04B74198]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0424D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
+       call      qword ptr [7FFC0428D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04BA64D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFC04BE7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04AEEA90]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04AEEB98]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0424D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BA6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,13D69001FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,13D69001FB8
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
+       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B168C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04E64A48
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC0437E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04AEEAA8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0424D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BA64D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC04021838
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04AEEA90]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04AEEB98]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0424D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BA6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1EA78401FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1EA78401FB8
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
+       call      qword ptr [7FFC04BE74C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B168C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04E88328
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC0437E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04AEEAA8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0424D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BA64D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0418FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04485B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04485908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04485938]
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
+       mov       r11,7FFC04041640
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04AEEA90]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04AEEB98]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0424D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BA6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,29874001FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,29874001FB8
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
+       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B168C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04F095C8
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC0437E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04AEEAA8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0424D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BA64D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC04021638
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04AEEA90]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04AEEB98]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0424D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BA6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2334F801FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2334F801FB8
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
+       call      qword ptr [7FFC04BB7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0425D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B168C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04EEF708
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC0437E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04AEEAA8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0424D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BA64D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0415FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04455B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04455908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04455938]
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
+       mov       r11,7FFC04011638
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04AEEA90]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04AEEB98]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0424D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BA6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,18863C01FD8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,18863C01FB8
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
+       call      qword ptr [7FFC04D0C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B168C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04F42F98
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC0437E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04AEEAA8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0424D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BA64D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC040217F8
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04AEEA90]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04AEEB98]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0424D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BA6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2615BC02008
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2615BC01FB8
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
+       call      qword ptr [7FFC04D87A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B168C8
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04F46308
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC0437E358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04AEEAA8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0424D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BA64D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC04022070
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B74180]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B74288]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,13D69001FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,13D69001FB8
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
+       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B48780
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04E64A48
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC043BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04B74198]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0428D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC04021838
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B74180]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B74288]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,1EA78401FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,1EA78401FB8
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
+       call      qword ptr [7FFC04BE74C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B48780
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04E88328
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC043BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04B74198]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0428D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0418FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04485B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04485908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04485938]
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
+       mov       r11,7FFC04041640
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B74180]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B74288]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,29874001FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,29874001FB8
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
+       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B48780
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04F095C8
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC043BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04B74198]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0428D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC04021638
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B74180]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B74288]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2334F801FC8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2334F801FB8
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
+       call      qword ptr [7FFC04BB7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0425D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B48780
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04EEF708
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC043BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04B74198]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0428D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0415FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04455B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04455908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04455938]
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
+       mov       r11,7FFC04011638
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B74180]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B74288]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,18863C01FD8
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,18863C01FB8
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
+       call      qword ptr [7FFC04D0C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B48780
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04F42F98
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC043BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04B74198]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0428D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC040217F8
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B74180]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
-       mov       rdx,[rbp-10]
-       mov       [rbp-8],rdx
-       mov       rdx,[rbp+10]
-       mov       rdx,[rdx+280]
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B74288]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0428D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-14],eax
-       mov       edx,[rbp-14]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,40
+       mov       rsi,rax
+       mov       rcx,2615BC02008
+       mov       rdi,[rcx]
+       mov       rcx,offset MT_System.Object
+       call      CORINFO_HELP_NEWSFAST
+       lea       rcx,[rsi+20]
+       mov       rdx,rax
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rcx,2615BC01FB8
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
+       call      qword ptr [7FFC04D87A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       [rbp-10],rax
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
-       mov       [rbp-18],rcx
        jmp       short M01_L01
 M01_L00:
-       mov       rcx,[rbp-20]
-       mov       rdx,7FFC04B48780
-       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
-       mov       [rbp-18],rax
+       mov       rdx,7FFC04F46308
+       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
+       mov       rdx,rax
 M01_L01:
-       mov       rcx,[rbp-18]
-       call      qword ptr [7FFC043BE358]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
-       mov       [rbp-10],rax
-       lea       rdx,[rbp-10]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04B74198]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
-       call      qword ptr [7FFC0428D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
+       mov       rcx,rdx
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
+       call      qword ptr [7FFC04465B18]
+       int       3
+M01_L05:
+       call      qword ptr [7FFC04465908]
+       int       3
+M01_L06:
+       call      qword ptr [7FFC04465938]
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
+       mov       r11,7FFC04022070
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,13D69001FC8
+       mov       rcx,1EA78401FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,13D69001FB8
+       mov       rcx,1EA78401FB8
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
-       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04BE74C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E64A48
+       mov       rdx,7FFC04E88328
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0418FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04465B18]
+       call      qword ptr [7FFC04485B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04465908]
+       call      qword ptr [7FFC04485908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04465938]
+       call      qword ptr [7FFC04485938]
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
-       mov       r11,7FFC04021838
+       mov       r11,7FFC04041640
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,13D69001FC8
+       mov       rcx,29874001FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,13D69001FB8
+       mov       rcx,29874001FB8
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
        call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E64A48
+       mov       rdx,7FFC04F095C8
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
-       mov       r11,7FFC04021838
+       mov       r11,7FFC04021638
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,13D69001FC8
+       mov       rcx,2334F801FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,13D69001FB8
+       mov       rcx,2334F801FB8
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
-       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04BB7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0425D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E64A48
+       mov       rdx,7FFC04EEF708
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0415FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04465B18]
+       call      qword ptr [7FFC04455B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04465908]
+       call      qword ptr [7FFC04455908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04465938]
+       call      qword ptr [7FFC04455938]
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
-       mov       r11,7FFC04021838
+       mov       r11,7FFC04011638
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,13D69001FC8
+       mov       rcx,18863C01FD8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,13D69001FB8
+       mov       rcx,18863C01FB8
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
-       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D0C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E64A48
+       mov       rdx,7FFC04F42F98
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
-       mov       r11,7FFC04021838
+       mov       r11,7FFC040217F8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,13D69001FC8
+       mov       rcx,2615BC02008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,13D69001FB8
+       mov       rcx,2615BC01FB8
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
-       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D87A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E64A48
+       mov       rdx,7FFC04F46308
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
-       mov       r11,7FFC04021838
+       mov       r11,7FFC04022070
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,1EA78401FC8
+       mov       rcx,29874001FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1EA78401FB8
+       mov       rcx,29874001FB8
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
-       call      qword ptr [7FFC04BE74C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E88328
+       mov       rdx,7FFC04F095C8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0418FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04485B18]
+       call      qword ptr [7FFC04465B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04485908]
+       call      qword ptr [7FFC04465908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04485938]
+       call      qword ptr [7FFC04465938]
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
-       mov       r11,7FFC04041640
+       mov       r11,7FFC04021638
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,1EA78401FC8
+       mov       rcx,2334F801FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1EA78401FB8
+       mov       rcx,2334F801FB8
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
-       call      qword ptr [7FFC04BE74C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04BB7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0425D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E88328
+       mov       rdx,7FFC04EEF708
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0418FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0415FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04485B18]
+       call      qword ptr [7FFC04455B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04485908]
+       call      qword ptr [7FFC04455908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04485938]
+       call      qword ptr [7FFC04455938]
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
-       mov       r11,7FFC04041640
+       mov       r11,7FFC04011638
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,1EA78401FC8
+       mov       rcx,18863C01FD8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1EA78401FB8
+       mov       rcx,18863C01FB8
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
-       call      qword ptr [7FFC04BE74C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D0C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E88328
+       mov       rdx,7FFC04F42F98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0418FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04485B18]
+       call      qword ptr [7FFC04465B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04485908]
+       call      qword ptr [7FFC04465908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04485938]
+       call      qword ptr [7FFC04465938]
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
-       mov       r11,7FFC04041640
+       mov       r11,7FFC040217F8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,1EA78401FC8
+       mov       rcx,2615BC02008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1EA78401FB8
+       mov       rcx,2615BC01FB8
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
-       call      qword ptr [7FFC04BE74C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D87A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0428D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04E88328
+       mov       rdx,7FFC04F46308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0418FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04485B18]
+       call      qword ptr [7FFC04465B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04485908]
+       call      qword ptr [7FFC04465908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04485938]
+       call      qword ptr [7FFC04465938]
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
-       mov       r11,7FFC04041640
+       mov       r11,7FFC04022070
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,29874001FC8
+       mov       rcx,2334F801FC8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,29874001FB8
+       mov       rcx,2334F801FB8
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
-       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04BB7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0425D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04F095C8
+       mov       rdx,7FFC04EEF708
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0415FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04465B18]
+       call      qword ptr [7FFC04455B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04465908]
+       call      qword ptr [7FFC04455908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04465938]
+       call      qword ptr [7FFC04455938]
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
-       mov       r11,7FFC04021638
+       mov       r11,7FFC04011638
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,29874001FC8
+       mov       rcx,18863C01FD8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,29874001FB8
+       mov       rcx,18863C01FB8
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
-       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D0C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04F095C8
+       mov       rdx,7FFC04F42F98
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
-       mov       r11,7FFC04021638
+       mov       r11,7FFC040217F8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,29874001FC8
+       mov       rcx,2615BC02008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,29874001FB8
+       mov       rcx,2615BC01FB8
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
-       call      qword ptr [7FFC04BC7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D87A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04F095C8
+       mov       rdx,7FFC04F46308
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
-       mov       r11,7FFC04021638
+       mov       r11,7FFC04022070
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,2334F801FC8
+       mov       rcx,18863C01FD8
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2334F801FB8
+       mov       rcx,18863C01FB8
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
-       call      qword ptr [7FFC04BB7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D0C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0425D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04EEF708
+       mov       rdx,7FFC04F42F98
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0415FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04455B18]
+       call      qword ptr [7FFC04465B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04455908]
+       call      qword ptr [7FFC04465908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04455938]
+       call      qword ptr [7FFC04465938]
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
-       mov       r11,7FFC04011638
+       mov       r11,7FFC040217F8
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,2334F801FC8
+       mov       rcx,2615BC02008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,2334F801FB8
+       mov       rcx,2615BC01FB8
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
-       call      qword ptr [7FFC04BB7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D87A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
-       call      qword ptr [7FFC0425D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04EEF708
+       mov       rdx,7FFC04F46308
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rdx,rax
 M01_L01:
        mov       rcx,rdx
-       call      qword ptr [7FFC0415FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
+       call      qword ptr [7FFC0416FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
-       call      qword ptr [7FFC04455B18]
+       call      qword ptr [7FFC04465B18]
        int       3
 M01_L05:
-       call      qword ptr [7FFC04455908]
+       call      qword ptr [7FFC04465908]
        int       3
 M01_L06:
-       call      qword ptr [7FFC04455938]
+       call      qword ptr [7FFC04465938]
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
-       mov       r11,7FFC04011638
+       mov       r11,7FFC04022070
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for Remove_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       mov       rcx,18863C01FD8
+       mov       rcx,2615BC02008
        mov       rdi,[rcx]
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_NEWSFAST
        lea       rcx,[rsi+20]
        mov       rdx,rax
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,18863C01FB8
+       mov       rcx,2615BC01FB8
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
-       call      qword ptr [7FFC04D0C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
+       call      qword ptr [7FFC04D87A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
        test      eax,eax
        jge       short M00_L01
 M00_L00:
        mov       rcx,rsi
        mov       edx,eax
        call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04F42F98
+       mov       rdx,7FFC04F46308
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
-       mov       r11,7FFC040217F8
+       mov       r11,7FFC04022070
        call      qword ptr [r11]
        test      eax,eax
        je        short M01_L12
        mov       eax,ebx
        jmp       short M01_L03
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B61298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFC04B44408]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFC04BC74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       mov       rcx,7FFC04F040D4
+       mov       rcx,7FFC04E7053C
        call      CORINFO_HELP_COUNTPROFILE32
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+8]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       rcx,[rbx+10]
        mov       r8,rcx
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F040D8
+       mov       rcx,7FFC04E70540
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+8]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFC04F040DC
+       mov       rcx,7FFC04E70544
        call      CORINFO_HELP_COUNTPROFILE32
        mov       rcx,[rbx+10]
        movsxd    rax,dword ptr [rbx+30]
        mov       edx,[rcx+8]
        cmp       rax,rdx
        jae       near ptr M01_L03
        xor       edx,edx
        mov       [rcx+rax*8+10],rdx
-       mov       rcx,7FFC04F040E0
+       mov       rcx,7FFC04E70548
        call      CORINFO_HELP_COUNTPROFILE32
        inc       dword ptr [rbx+34]
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
 M01_L01:
-       mov       rcx,7FFC04F040D0
+       mov       rcx,7FFC04E70538
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
-       mov       rdx,7FFC04475198
+       mov       rdx,7FFC04455198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC049060E8]
+       call      qword ptr [7FFC048E4900]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0423D4A0]
+       call      qword ptr [7FFC0421D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
        int       3
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
 ; Total bytes of code 345
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFC04BC7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B61298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F040D4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F040D8
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
-       mov       rcx,7FFC04F040DC
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
-       mov       rcx,7FFC04F040E0
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
-       mov       rcx,7FFC04F040D0
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
-       mov       rdx,7FFC04475198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC049060E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0423D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B61298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F040D4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F040D8
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
-       mov       rcx,7FFC04F040DC
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
-       mov       rcx,7FFC04F040E0
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
-       mov       rcx,7FFC04F040D0
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
-       mov       rdx,7FFC04475198
+       mov       rdx,7FFC04455198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC049060E8]
+       call      qword ptr [7FFC048E6418]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0423D4A0]
+       call      qword ptr [7FFC0421D4A0]
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
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B61298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F040D4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F040D8
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
-       mov       rcx,7FFC04F040DC
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
-       mov       rcx,7FFC04F040E0
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
-       mov       rcx,7FFC04F040D0
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
-       mov       rdx,7FFC04475198
+       mov       rdx,7FFC04435198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC049060E8]
+       call      qword ptr [7FFC048C60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0423D4A0]
+       call      qword ptr [7FFC041FD4A0]
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
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B61298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B76868]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F040D4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F040D8
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
-       mov       rcx,7FFC04F040DC
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
-       mov       rcx,7FFC04F040E0
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
-       mov       rcx,7FFC04F040D0
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
        mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC049060E8]
+       call      qword ptr [7FFC04916100]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0423D4A0]
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
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B61298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04BF5EF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F040D4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F040D8
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
-       mov       rcx,7FFC04F040DC
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
-       mov       rcx,7FFC04F040E0
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
-       mov       rcx,7FFC04F040D0
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
-       mov       rdx,7FFC04475198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC049060E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0423D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B2F708]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B61298]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BE6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04D34C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04F040D4
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04F040D8
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
-       mov       rcx,7FFC04F040DC
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
-       mov       rcx,7FFC04F040E0
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
-       mov       rcx,7FFC04F040D0
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
        mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
        call      qword ptr [7FFC049060E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0423D4A0]
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
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044D45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BE64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B44408]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04E7053C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04E70540
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
-       mov       rcx,7FFC04E70544
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
-       mov       rcx,7FFC04E70548
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
-       mov       rcx,7FFC04E70538
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E4900]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
        call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04B44408]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       mov       rcx,7FFC04E7053C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04E70540
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
-       mov       rcx,7FFC04E70544
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
-       mov       rcx,7FFC04E70548
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
-       mov       rcx,7FFC04E70538
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
        mov       rdx,7FFC04455198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E4900]
+       call      qword ptr [7FFC048E6418]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0421D4A0]
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
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B44408]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04E7053C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04E70540
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
-       mov       rcx,7FFC04E70544
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
-       mov       rcx,7FFC04E70548
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
-       mov       rcx,7FFC04E70538
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04435198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E4900]
+       call      qword ptr [7FFC048C60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC041FD4A0]
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
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B44408]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04B76868]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04E7053C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04E70540
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
-       mov       rcx,7FFC04E70544
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
-       mov       rcx,7FFC04E70548
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
-       mov       rcx,7FFC04E70538
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E4900]
+       call      qword ptr [7FFC04916100]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0423D4A0]
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
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B44408]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04BF5EF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04E7053C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04E70540
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
-       mov       rcx,7FFC04E70544
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
-       mov       rcx,7FFC04E70548
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
-       mov       rcx,7FFC04E70538
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E4900]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0420D4A0]
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
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
+       push      rsi
+       push      rbx
+       sub       rsp,28
+       mov       rbx,rcx
+       mov       rsi,[rbx+2A0]
+       mov       edx,[rbx+2B4]
+       mov       rcx,rsi
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04B44408]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
-       nop
-       add       rsp,30
-       pop       rbp
+       call      qword ptr [7FFC04D34C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rcx,7FFC04E7053C
-       call      CORINFO_HELP_COUNTPROFILE32
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+8]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
-       mov       r8d,[rbx+30]
-       sub       r8d,esi
-       mov       [rsp+20],r8d
-       mov       rcx,[rbx+10]
-       mov       r8,rcx
-       lea       edx,[rsi+1]
-       mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
 M01_L00:
-       mov       rcx,7FFC04E70540
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
-       mov       rcx,7FFC04E70544
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
-       mov       rcx,7FFC04E70548
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
-       mov       rcx,7FFC04E70538
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E4900]
+       call      qword ptr [7FFC049060E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0423D4A0]
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
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       mov       r8d,[rbx+30]
+       sub       r8d,esi
+       mov       [rsp+20],r8d
+       mov       r8,[rbx+10]
+       mov       rcx,[rbx+10]
+       lea       edx,[rsi+1]
+       mov       r9d,esi
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
-       nop
-       add       rsp,30
-       pop       rbp
-       ret
-; Total bytes of code 60
+; Total bytes of code 265
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04445198
+       mov       rdx,7FFC04455198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D60E8]
+       call      qword ptr [7FFC048E6418]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0420D4A0]
+       call      qword ptr [7FFC0421D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04445198
+       mov       rdx,7FFC04435198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D60E8]
+       call      qword ptr [7FFC048C60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0420D4A0]
+       call      qword ptr [7FFC041FD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B76868]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04445198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D60E8]
+       call      qword ptr [7FFC04916100]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0420D4A0]
+       call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04BF5EF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B44DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D34C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04445198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D60E8]
+       call      qword ptr [7FFC049060E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0420D4A0]
+       call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04435198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048C60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC041FD4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B76868]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC04916100]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04BF5EF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B54DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D34C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04455198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048E6418]
+       call      qword ptr [7FFC049060E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0421D4A0]
+       call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B76868]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04435198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048C60E8]
+       call      qword ptr [7FFC04916100]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC041FD4A0]
+       call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04BF5EF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04435198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048C60E8]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC041FD4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B34DF8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D34C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04435198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048C60E8]
+       call      qword ptr [7FFC049060E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC041FD4A0]
+       call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC04097750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B76868]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04BF5EF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04475198
+       mov       rdx,7FFC04445198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC04916100]
+       call      qword ptr [7FFC048D60E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0423D4A0]
+       call      qword ptr [7FFC0420D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B76868]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D34C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
        mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC04916100]
+       call      qword ptr [7FFC049060E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
        call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
```
**Diff for RemoveAt_SortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04BF5EF0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04D34C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       mov       rdx,7FFC04445198
+       mov       rdx,7FFC04475198
        call      CORINFO_HELP_STRCNS
        mov       rbp,rax
-       call      qword ptr [7FFC048D60E8]
+       call      qword ptr [7FFC049060E8]
        mov       r9,rax
        mov       rdx,rbp
        mov       r8,rdi
        mov       rcx,rsi
-       call      qword ptr [7FFC0420D4A0]
+       call      qword ptr [7FFC0423D4A0]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
 M01_L02:
        sub       eax,esi
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        mov       r8d,[rbx+30]
        sub       r8d,esi
        mov       [rsp+20],r8d
        mov       r8,[rbx+10]
        mov       rcx,[rbx+10]
        lea       edx,[rsi+1]
        mov       r9d,esi
-       call      qword ptr [7FFC040A7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       near ptr M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC04B642A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
        mov       rcx,[rbp-8]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC0426D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
+       call      qword ptr [7FFC0427D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
        mov       [rbp-0C],eax
        mov       edx,[rbp-0C]
        mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
+       call      qword ptr [7FFC04BD7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0427D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
+       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
        mov       [rbp-8],rax
        mov       rcx,[rbp-8]
        lea       rdx,[rbp+18]
        cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
+       call      qword ptr [7FFC04BD7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
        nop
        add       rsp,30
        pop       rbp
        ret
 ; Total bytes of code 60
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0426D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0426D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0426D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0426D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0426D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B0EBB0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0426D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BC6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0426D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BC64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B642A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0427D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0427D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B642A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0427D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0427D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B642A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0427D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0427D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04485878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B642A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0427D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0427D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B642A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0427D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0427D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC04B642A0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
-       mov       rcx,[rbp-8]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC0427D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
-       mov       [rbp-0C],eax
-       mov       edx,[rbp-0C]
-       mov       rcx,[rbp+10]
-       call      qword ptr [7FFC04BD7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
-       call      qword ptr [7FFC0427D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC044C45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
-       mov       [rbp-8],rax
-       mov       rcx,[rbp-8]
-       lea       rdx,[rbp+18]
-       cmp       [rcx],ecx
-       call      qword ptr [7FFC04BD7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
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
+       call      qword ptr [7FFC04465878]
+       int       3
+M01_L02:
+       sub       eax,r9d
+       mov       [rsp+20],eax
+       mov       r8,[rbx+8]
+       mov       rcx,[rbx+8]
+       lea       edx,[r9+1]
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       jmp       short M01_L00
+M01_L03:
+       call      CORINFO_HELP_RNGCHKFAIL
+       int       3
+; Total bytes of code 101
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04465878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04465878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04465878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04465878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04465878]
+       call      qword ptr [7FFC04485878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04465878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04465878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
-       call      qword ptr [7FFC0428D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
+       call      qword ptr [7FFC0426D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
-       call      qword ptr [7FFC04485878]
+       call      qword ptr [7FFC04465878]
        int       3
 M01_L02:
        sub       eax,r9d
        mov       [rsp+20],eax
        mov       r8,[rbx+8]
        mov       rcx,[rbx+8]
        lea       edx,[r9+1]
-       call      qword ptr [7FFC040D7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
+       call      qword ptr [7FFC040B7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
        jmp       short M01_L00
 M01_L03:
        call      CORINFO_HELP_RNGCHKFAIL
```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
**Diff for RemoveAt_FastSortedList method between:**
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
.NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```diff

```
