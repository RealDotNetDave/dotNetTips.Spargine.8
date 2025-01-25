## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D4EEA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CC5CB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5B6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FF94CC5CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CEA4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5B64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D554120]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CC7CB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5D7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FF94CC7CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CEC4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5D7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2A8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC7CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD7EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2A8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC5CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD5EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2A8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC6CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD6EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2A8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC6CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD6EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2A8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC4CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD4EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2A8]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC4CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD4EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D51EBC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D54B4C0]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5D58F0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
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
       mov       rcx,7FF94D8CF5AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF94D8CF5B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D8CF5B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D8CF5B8
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF94D8CF5A8
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
       mov       rdx,7FF94CD6A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2E44C8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC3D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 345
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CE37690]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5D5950]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D564C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D55F668]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5E74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
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
       mov       rcx,7FF94D86E53C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAE7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAE7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF94D86E540
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D86E544
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D86E548
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF94D86E538
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
       mov       rdx,7FF94CD7A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2F6B08]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC4D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 345
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CED4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5E7510]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B0]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D4FF8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2D44C8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B0]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D4EF8B8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD3A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2C44C8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC0D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B0]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D534C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2C5548]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B0]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5BC4E0]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD7A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2F4378]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC4D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAE7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAE7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B0]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D58DBD8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD6A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2E5548]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC3D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B0]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D714C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD6A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2F44C8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC3D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D4FD6E0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+278]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D4FD7E8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CC5CB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5B51D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 119
```
```assembly
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
       mov       rdx,7FF94D5153D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp-10]
       call      qword ptr [7FF94CE67750]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D4FD6F8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF94CC5CBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 39
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CEA45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5B5218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D554000]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+278]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D554108]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CC7CB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5D7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 119
```
```assembly
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
       mov       rdx,7FF94D5372A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-10],rax
M01_L01:
       mov       rcx,[rbp-10]
       call      qword ptr [7FF94CE86C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rbp-18],rax
       mov       rdx,[rbp-18]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D554018]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon>)
       nop
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF94CC7CBC8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 39
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CEC4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5D7AB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,2BDC9005620
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2BDC9005608
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
       call      qword ptr [7FF94D5A5FF8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF94CC4CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L00
; Total bytes of code 178
```
```assembly
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
       mov       rdx,7FF94D8369D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF94CB5FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L13
       add       ebp,ebx
       test      rdi,rdi
       je        short M01_L07
       cmp       ebx,ebp
       jl        short M01_L11
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       ecx,2
       call      qword ptr [7FF94CD4ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD4EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF94CD4EB20]
       int       3
M01_L07:
       mov       eax,ebx
       jmp       short M01_L10
M01_L08:
       cmp       eax,r14d
       jae       short M01_L14
       mov       ecx,eax
       cmp       qword ptr [rsi+rcx*8+10],0
       jne       short M01_L09
       jmp       short M01_L03
M01_L09:
       inc       eax
M01_L10:
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
       mov       r11,7FF94CA117C0
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L12
       mov       eax,ebx
       jmp       short M01_L03
M01_L12:
       inc       ebx
       cmp       ebx,ebp
       jl        short M01_L11
       jmp       short M01_L02
M01_L13:
       mov       [rsp+20],ebp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9d,ebx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M01_L03
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,23DB7C05620
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23DB7C05608
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
       call      qword ptr [7FF94D5C7A80]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF94CC6CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L00
; Total bytes of code 178
```
```assembly
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
       mov       rdx,7FF94D867120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF94CB7FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L13
       add       ebp,ebx
       test      rdi,rdi
       je        short M01_L07
       cmp       ebx,ebp
       jl        short M01_L11
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       ecx,2
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD6EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF94CD6EB20]
       int       3
M01_L07:
       mov       eax,ebx
       jmp       short M01_L10
M01_L08:
       cmp       eax,r14d
       jae       short M01_L14
       mov       ecx,eax
       cmp       qword ptr [rsi+rcx*8+10],0
       jne       short M01_L09
       jmp       short M01_L03
M01_L09:
       inc       eax
M01_L10:
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
       mov       r11,7FF94CA315C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L12
       mov       eax,ebx
       jmp       short M01_L03
M01_L12:
       inc       ebx
       cmp       ebx,ebp
       jl        short M01_L11
       jmp       short M01_L02
M01_L13:
       mov       [rsp+20],ebp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9d,ebx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M01_L03
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,2BB28003628
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2BB28003610
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
       call      qword ptr [7FF94D5C6EB0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF94CC6CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L00
; Total bytes of code 178
```
```assembly
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
       mov       rdx,7FF94D8F92E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF94CB7FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L13
       add       ebp,ebx
       test      rdi,rdi
       je        short M01_L07
       cmp       ebx,ebp
       jl        short M01_L11
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       ecx,2
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD6EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF94CD6EB20]
       int       3
M01_L07:
       mov       eax,ebx
       jmp       short M01_L10
M01_L08:
       cmp       eax,r14d
       jae       short M01_L14
       mov       ecx,eax
       cmp       qword ptr [rsi+rcx*8+10],0
       jne       short M01_L09
       jmp       short M01_L03
M01_L09:
       inc       eax
M01_L10:
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
       mov       r11,7FF94CA315B8
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L12
       mov       eax,ebx
       jmp       short M01_L03
M01_L12:
       inc       ebx
       cmp       ebx,ebp
       jl        short M01_L11
       jmp       short M01_L02
M01_L13:
       mov       [rsp+20],ebp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9d,ebx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M01_L03
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,29848005628
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,29848005608
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
       call      qword ptr [7FF94D5ED1E8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF94CC5CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L00
; Total bytes of code 178
```
```assembly
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
       mov       rdx,7FF94D913AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF94CB6FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L13
       add       ebp,ebx
       test      rdi,rdi
       je        short M01_L07
       cmp       ebx,ebp
       jl        short M01_L11
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       ecx,2
       call      qword ptr [7FF94CD5ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD5EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF94CD5EB20]
       int       3
M01_L07:
       mov       eax,ebx
       jmp       short M01_L10
M01_L08:
       cmp       eax,r14d
       jae       short M01_L14
       mov       ecx,eax
       cmp       qword ptr [rsi+rcx*8+10],0
       jne       short M01_L09
       jmp       short M01_L03
M01_L09:
       inc       eax
M01_L10:
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
       mov       r11,7FF94CA21760
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L12
       mov       eax,ebx
       jmp       short M01_L03
M01_L12:
       inc       ebx
       cmp       ebx,ebp
       jl        short M01_L11
       jmp       short M01_L02
M01_L13:
       mov       [rsp+20],ebp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9d,ebx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M01_L03
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,269F8005648
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,269F8005618
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
       call      qword ptr [7FF94D6AFF90]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF94CC7CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L00
; Total bytes of code 178
```
```assembly
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
       mov       rdx,7FF94D93E428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF94CB8FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L13
       add       ebp,ebx
       test      rdi,rdi
       je        short M01_L07
       cmp       ebx,ebp
       jl        short M01_L11
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       ecx,2
       call      qword ptr [7FF94CD7ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD7EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF94CD7EB20]
       int       3
M01_L07:
       mov       eax,ebx
       jmp       short M01_L10
M01_L08:
       cmp       eax,r14d
       jae       short M01_L14
       mov       ecx,eax
       cmp       qword ptr [rsi+rcx*8+10],0
       jne       short M01_L09
       jmp       short M01_L03
M01_L09:
       inc       eax
M01_L10:
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
       mov       r11,7FF94CA41D88
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L12
       mov       eax,ebx
       jmp       short M01_L03
M01_L12:
       inc       ebx
       cmp       ebx,ebp
       jl        short M01_L11
       jmp       short M01_L02
M01_L13:
       mov       [rsp+20],ebp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9d,ebx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M01_L03
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       mov       rcx,29F0F005658
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,29F0F005630
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
       call      qword ptr [7FF94D7774C8]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF94CC6CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       jmp       short M00_L00
; Total bytes of code 178
```
```assembly
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
       mov       rdx,7FF94D932990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF94CB7FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       rcx,rax
       mov       rax,offset MT_System.Collections.Generic.GenericEqualityComparer`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L13
       add       ebp,ebx
       test      rdi,rdi
       je        short M01_L07
       cmp       ebx,ebp
       jl        short M01_L11
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       ecx,2
       call      qword ptr [7FF94CD6ED00]
       int       3
M01_L05:
       call      qword ptr [7FF94CD6EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF94CD6EB20]
       int       3
M01_L07:
       mov       eax,ebx
       jmp       short M01_L10
M01_L08:
       cmp       eax,r14d
       jae       short M01_L14
       mov       ecx,eax
       cmp       qword ptr [rsi+rcx*8+10],0
       jne       short M01_L09
       jmp       short M01_L03
M01_L09:
       inc       eax
M01_L10:
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
       mov       r11,7FF94CA31E68
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L12
       mov       eax,ebx
       jmp       short M01_L03
M01_L12:
       inc       ebx
       cmp       ebx,ebp
       jl        short M01_L11
       jmp       short M01_L02
M01_L13:
       mov       [rsp+20],ebp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9d,ebx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       jmp       near ptr M01_L03
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 287
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D50F570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D54B4C0]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5D6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
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
       mov       rcx,7FF94D8CEFF4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF94D8CEFF8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D8CEFFC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D8CF000
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF94D8CEFF0
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
       mov       rdx,7FF94CD6A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2E5548]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC3D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 345
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CEC4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5D64F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D544C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D53F668]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5C7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
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
       mov       rcx,7FF94D84E044
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF94D84E048
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D84E04C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF94D84E050
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF94D84E040
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
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2D5548]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC2D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 345
```
```assembly
; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       eax,[rcx+30]
       ret
; Total bytes of code 4
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CEB4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5C7AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2AC]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D544C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2D5548]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC2D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2AC]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D544570]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD5A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2E44C8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC2D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2AC]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D534C78]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2C5878]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2AC]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D565110]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2C5548]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2AC]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D58DE30]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD6A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2E5548]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC3D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2AC]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF94D6F5500]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+30]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 50
```
```assembly
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
M01_L00:
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
       mov       rdx,7FF94CD4A0F8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF94D2C5878]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF94CC1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D51EA18]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CC8CB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5E5FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FF94CC8CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CED4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5E5FF8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF94D534120]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF94CC5CB10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94D5B7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       mov       edx,[rbp+18]
       call      qword ptr [7FF94CC5CBD8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 37
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       eax,[rcx+10]
       ret
; Total bytes of code 4
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF94CEA4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF94D5B7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       edx,[rbx+2AC]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC8CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD8EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAE7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       edx,[rbx+2AC]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC5CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD5EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       edx,[rbx+2AC]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC4CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD4EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       edx,[rbx+2AC]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC5CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD5EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       edx,[rbx+2AC]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC6CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD6EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+288]
       mov       edx,[rbx+2AC]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF94CC7CBD8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       eax,[rsi+10]
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 51
```
```assembly
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
M01_L00:
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
       call      qword ptr [7FF94CD7EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF94CAD7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

