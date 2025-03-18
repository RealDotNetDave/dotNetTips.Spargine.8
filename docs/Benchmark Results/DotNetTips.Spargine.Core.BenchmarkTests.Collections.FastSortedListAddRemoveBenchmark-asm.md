## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF9837EFD50]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F7D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838C7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF982F7D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF9831B4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838C7A80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF98380F018]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F7D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838C6490]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF982F7D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF9831B45A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838C64A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2B0]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F4D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98303EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2B0]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F6D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98305EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2B0]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F6D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98305EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2B0]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F6D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98305EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2B0]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F4D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98303EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtFastSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+298]
       mov       edx,[rbx+2B0]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F5D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98304EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982DA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF983834AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF98381DDF8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838B7A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       rcx,7FF983BB922C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF983BB9230
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983BB9234
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983BB9238
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF983BB9228
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
       mov       rdx,7FF98304AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835C7EB8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F1D4A0]
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
       call      qword ptr [7FF9831A4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838B7AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF983836028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF983840C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838BC480]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       rcx,7FF983B38554
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF983B38558
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983B3855C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983B38560
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF983B38550
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
       mov       rdx,7FF98304AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835C7EB8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F1D4A0]
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
       call      qword ptr [7FF9831A4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838BC4E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A8]
       mov       edx,[rbx+2B8]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983846028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98305AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835D7ED0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F2D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A8]
       mov       edx,[rbx+2B8]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983826028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98303AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835B7ED0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F0D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A8]
       mov       edx,[rbx+2B8]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983816028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835A7EB8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A8]
       mov       edx,[rbx+2B8]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983816028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835A7EB8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A8]
       mov       edx,[rbx+2B8]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983846268]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98305AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835D7ED0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F2D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAtSortedListComparer()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A8]
       mov       edx,[rbx+2B8]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983836298]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98304AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835C7EB8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9837EFC30]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+280]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9837EFD38]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F7D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838C74B0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       rdx,7FF9838356C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-18],rax
M01_L01:
       mov       rcx,[rbp-18]
       call      qword ptr [7FF983176C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rbp-10],rax
       lea       rdx,[rbp-10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9837EFC48]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
       call      qword ptr [7FF982F7D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       call      qword ptr [7FF9831B4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838C74F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9838158C0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+280]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838159C8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F5D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-14],eax
       mov       edx,[rbp-14]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838AD1D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       rdx,7FF983807568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-18],rax
M01_L01:
       mov       rcx,[rbp-18]
       call      qword ptr [7FF983156C40]; System.Collections.Generic.Comparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
       mov       [rbp-10],rax
       lea       rdx,[rbp-10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838158D8]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IComparer`1<System.__Canon> ByRef)
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
       call      qword ptr [7FF982F5D8D8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Remove(System.__Canon)
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
       call      qword ptr [7FF983194B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838AD218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,1AAAE003ED0
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1AAAE003EC0
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
       call      qword ptr [7FF98389C7E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF982F4D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF983B31A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF982E4FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF98303ED00]
       int       3
M01_L05:
       call      qword ptr [7FF98303EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF98303EB20]
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
       mov       r11,7FF982D01808
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,23954803ED0
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,23954803EC0
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
       call      qword ptr [7FF9838AC7E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF982F5D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF983B42490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF982E5FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF98304ED00]
       int       3
M01_L05:
       call      qword ptr [7FF98304EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF98304EB20]
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
       mov       r11,7FF982D11610
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,252B9805EC8
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,252B9805EB8
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
       call      qword ptr [7FF9838CC498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF982F7D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF983BF58B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF982E7FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF98306ED00]
       int       3
M01_L05:
       call      qword ptr [7FF98306EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF98306EB20]
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
       mov       r11,7FF982D31608
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,20012005EC8
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20012005EB8
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
       call      qword ptr [7FF98389C498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF982F4D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF983BCABA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF982E4FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF98303ED00]
       int       3
M01_L05:
       call      qword ptr [7FF98303EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF98303EB20]
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
       mov       r11,7FF982D01600
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,29B9B803ED0
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,29B9B803EC0
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
       call      qword ptr [7FF9838CC7E0]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF982F7D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF983BFA758
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF982E7FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF98306ED00]
       int       3
M01_L05:
       call      qword ptr [7FF98306EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF98306EB20]
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
       mov       r11,7FF982D31620
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,25C6A405EC8
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,25C6A405EB8
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
       call      qword ptr [7FF9838CC498]; System.Array.IndexOf[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon, Int32, Int32)
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
       call      qword ptr [7FF982F7D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF983BF9FC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      qword ptr [7FF982E7FC30]; System.Collections.Generic.EqualityComparer`1[[System.__Canon, System.Private.CoreLib]].get_Default()
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
       call      qword ptr [7FF98306ED00]
       int       3
M01_L05:
       call      qword ptr [7FF98306EAF0]
       int       3
M01_L06:
       call      qword ptr [7FF98306EB20]
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
       mov       r11,7FF982D31620
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF983814AC8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9837FDDF8]; Precode of System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF983897A68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       rcx,7FF983B9950C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF983B99510
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983B99514
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983B99518
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF983B99508
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835A66D0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
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
       call      qword ptr [7FF983184B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF983897AC8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF983816028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF983820C28]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF98389C7C8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       mov       rcx,7FF983B18604
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+8]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       rcx,[rbx+10]
       mov       r8,rcx
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
M01_L00:
       mov       rcx,7FF983B18608
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+8]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983B1860C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+10]
       movsxd    rax,dword ptr [rbx+30]
       mov       edx,[rcx+8]
       cmp       rax,rdx
       jae       near ptr M01_L03
       xor       edx,edx
       mov       [rcx+rax*8+10],rdx
       mov       rcx,7FF983B18610
       call      CORINFO_HELP_COUNTPROFILE32
       inc       dword ptr [rbx+34]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,7FF983B18600
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835AC270]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
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
       call      qword ptr [7FF983184B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF98389C828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B4]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983816028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835AC270]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B4]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983816028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835AC270]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B4]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983816028]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835A7ED0]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B4]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF98380FB70]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98305AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835E60E8]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F2D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DC7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B4]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9838161A8]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98302AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835A7A98]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982EFD4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_SortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+2A0]
       mov       edx,[rbx+2B4]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF983836298]; System.Collections.Generic.SortedList`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       mov       rdx,7FF98304AC28
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FF9835C7A98]
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,rdi
       mov       rcx,rsi
       call      qword ptr [7FF982F1D4A0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       sub       eax,esi
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       r8d,[rbx+30]
       sub       r8d,esi
       mov       [rsp+20],r8d
       mov       r8,[rbx+10]
       mov       rcx,[rbx+10]
       lea       edx,[rsi+1]
       mov       r9d,esi
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       near ptr M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF9837ED9E0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F5D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838A51D0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF982F5D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF9831945A0]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838A51E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
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
       call      qword ptr [7FF9838354D0]; DotNetTips.Spargine.Core.Collections.Generic.FastSortedList`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F6D820]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       [rbp-0C],eax
       mov       edx,[rbp-0C]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9838BC480]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
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
       call      qword ptr [7FF982F6D8E8]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF9831A4B28]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       lea       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9838BC498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 60
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2B4]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F6D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98305EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2B4]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F4D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98303EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2B4]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F4D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98303EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2B4]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F5D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98304EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982DA7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2B4]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F4D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98303EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982D97750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.FastSortedListAddRemoveBenchmark.RemoveAt_FastSortedList()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+290]
       mov       edx,[rbx+2B4]
       cmp       [rsi],sil
       mov       rcx,rsi
       call      qword ptr [7FF982F6D8E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAt(Int32)
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
       call      qword ptr [7FF98305EA60]
       int       3
M01_L02:
       sub       eax,r9d
       mov       [rsp+20],eax
       mov       r8,[rbx+8]
       mov       rcx,[rbx+8]
       lea       edx,[r9+1]
       call      qword ptr [7FF982DB7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 101
```

