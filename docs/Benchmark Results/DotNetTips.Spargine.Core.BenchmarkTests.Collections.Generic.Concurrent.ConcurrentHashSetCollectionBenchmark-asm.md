## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L01
M01_L00:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CE83D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
       jmp       short M01_L00
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE84038
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5CE3EE80]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
M01_L09:
       cmp       edi,esi
       jl        short M01_L08
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 450
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE5CEA5CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L01:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEA5FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5CEC4330]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
M01_L09:
       cmp       edi,esi
       jl        short M01_L08
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 450
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE5CEA5C58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L01:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEA5F20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5CEC4330]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       cmp       edi,esi
       jge       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 452
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C96ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE5CE95CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L01:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE95FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5CEB4330]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
M01_L09:
       cmp       edi,esi
       jl        short M01_L08
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 450
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE5CEA5C58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L01:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEA5F20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5CEC4330]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
M01_L09:
       cmp       edi,esi
       jl        short M01_L08
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 450
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE5CEAAE78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L01:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEAB140
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5CECE058]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
M01_L09:
       cmp       edi,esi
       jl        short M01_L08
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 450
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE5CFC2428
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L01:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CFC26F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFF7E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       cmp       edi,esi
       jge       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 452
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       mov       [rsp+20],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdx
       mov       rdx,7FFE5D072D68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L01:
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5D073030
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L03:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rsi
       mov       edx,1F
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rdi,[rdx+18]
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r9,rax
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5D094180]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       mov       rcx,[rbx+18]
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rbx,[rbp+10]
       mov       [rbx+18],ecx
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L07
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L06
       cmp       edi,esi
       jl        short M01_L04
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       cmp       edi,esi
       jge       short M01_L09
M01_L08:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M01_L10
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L11
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 452
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5CEB46B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L08
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       je        short M01_L04
M01_L02:
       cmp       edi,[rbp+18]
       je        short M01_L05
M01_L03:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L02
M01_L04:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE5CEB4808
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L03
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 218
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5CEA6558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L07
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       cmp       edi,[rbp+18]
       jne       short M01_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFE5CEA66B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L03
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 220
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95ADF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5CE864C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L08
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       je        short M01_L04
M01_L02:
       cmp       edi,[rbp+18]
       je        short M01_L05
M01_L03:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L02
M01_L04:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE5CE86618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L03
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 218
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5CEA64C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L07
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       cmp       edi,[rbp+18]
       jne       short M01_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFE5CEA6618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L03
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 220
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97ADF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5CEA6558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L07
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       cmp       edi,[rbp+18]
       jne       short M01_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFE5CEA66B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L03
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 220
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C96ADF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5CF02A78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L07
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       cmp       edi,[rbp+18]
       jne       short M01_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFE5CF02BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L03
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 220
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94ADF0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5CF98288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L08
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       je        short M01_L04
M01_L02:
       cmp       edi,[rbp+18]
       je        short M01_L05
M01_L03:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L02
M01_L04:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rdx,7FFE5CF983E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L07:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L03
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 218
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95A9F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFE5D053750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L01:
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       edi,eax
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       mov       eax,edi
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       short M01_L07
       mov       eax,edx
       mov       rbp,[rcx+rax*8+10]
       test      rbp,rbp
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       cmp       edi,[rbp+18]
       jne       short M01_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+30]
       test      r11,r11
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFE5D0538A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L05:
       mov       rcx,[rbx+8]
       mov       rdx,[rbp+8]
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L06
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       mov       rbp,[rbp+10]
       test      rbp,rbp
       jne       short M01_L03
       jmp       short M01_L02
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 220
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C97ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CEEE4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CEEE4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CEEE4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CF0D338]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L19
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,2336E767350
       mov       r8,r9
       call      qword ptr [7FFE5CF0D428]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L02
M02_L01:
       mov       rdx,[rdi+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M02_L08
       mov       r8d,ecx
       add       eax,[rdx+r8*4+10]
       jo        near ptr M02_L12
       add       ecx,1
       jo        near ptr M02_L12
M02_L02:
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+10]
       mov       rdx,[rdx+18]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       short M02_L03
       test      eax,eax
       jge       short M02_L01
M02_L03:
       mov       ecx,[rbx+8]
       sub       ecx,eax
       jo        near ptr M02_L12
       cmp       ecx,esi
       jl        near ptr M02_L10
       test      eax,eax
       jl        near ptr M02_L10
       xor       r8d,r8d
       mov       [rbp-50],r8
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovge    r8d,edx
       mov       eax,r8d
       test      r8d,r8d
       je        near ptr M02_L13
M02_L04:
       test      eax,eax
       je        near ptr M02_L14
M02_L05:
       mov       r8,[rdi+10]
       mov       r14,[r8+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jle       near ptr M02_L16
M02_L06:
       cmp       r15d,r13d
       jae       short M02_L08
       mov       r8d,r15d
       mov       rax,[r14+r8*8+10]
       test      rax,rax
       jne       short M02_L09
M02_L07:
       add       r15d,1
       jo        near ptr M02_L12
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L09:
       mov       [rbp-58],rax
       mov       r8,[rax+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        short M02_L12
       mov       rcx,[rbp-58]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       rax,rcx
       jne       short M02_L09
       jmp       short M02_L07
M02_L10:
       call      qword ptr [7FFE5CA054D0]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L11
       call      qword ptr [7FFE5CA051D0]
       mov       r14,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,335F
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFE5C4FF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5A47B0]
       mov       esi,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFE5CA052A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFE5CA050C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2336E777578
       mov       r8,rbx
       call      qword ptr [7FFE5C5AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       ebx,[rbp-48]
       xor       esi,esi
       test      ebx,ebx
       jle       short M02_L18
M02_L17:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M02_L21
       mov       eax,esi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       esi,1
       jo        short M02_L20
       cmp       esi,ebx
       jl        short M02_L17
M02_L18:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       rcx,rdx
       mov       rdx,7FFE5CEEED00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       ebx,[rbp-48]
       xor       esi,esi
       cmp       esi,ebx
       jge       short M02_L23
M02_L22:
       mov       rdi,[rbp+10]
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M02_L24
       mov       eax,esi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       esi,1
       jo        short M02_L25
       cmp       esi,ebx
       jl        short M02_L22
M02_L23:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 806
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C96AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C96ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CEFF240]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L19
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,2D490B27350
       mov       r8,r9
       call      qword ptr [7FFE5CEFF330]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L02
M02_L01:
       mov       rdx,[rdi+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M02_L08
       mov       r8d,ecx
       add       eax,[rdx+r8*4+10]
       jo        near ptr M02_L12
       add       ecx,1
       jo        near ptr M02_L12
M02_L02:
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+10]
       mov       rdx,[rdx+18]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       short M02_L03
       test      eax,eax
       jge       short M02_L01
M02_L03:
       mov       ecx,[rbx+8]
       sub       ecx,eax
       jo        near ptr M02_L12
       cmp       ecx,esi
       jl        near ptr M02_L10
       test      eax,eax
       jl        near ptr M02_L10
       xor       r8d,r8d
       mov       [rbp-50],r8
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovge    r8d,edx
       mov       eax,r8d
       test      r8d,r8d
       je        near ptr M02_L13
M02_L04:
       test      eax,eax
       je        near ptr M02_L14
M02_L05:
       mov       r8,[rdi+10]
       mov       r14,[r8+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jle       near ptr M02_L16
M02_L06:
       cmp       r15d,r13d
       jae       short M02_L08
       mov       r8d,r15d
       mov       rax,[r14+r8*8+10]
       test      rax,rax
       jne       short M02_L09
M02_L07:
       add       r15d,1
       jo        near ptr M02_L12
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L09:
       mov       [rbp-58],rax
       mov       r8,[rax+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        short M02_L12
       mov       rcx,[rbp-58]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       rax,rcx
       jne       short M02_L09
       jmp       short M02_L07
M02_L10:
       call      qword ptr [7FFE5C9F54D0]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L11
       call      qword ptr [7FFE5C9F51D0]
       mov       r14,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,335F
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFE5C4EF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5947B0]
       mov       esi,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFE5C9F52A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFE5C9F50C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D490B37598
       mov       r8,rbx
       call      qword ptr [7FFE5C59D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       ebx,[rbp-48]
       xor       esi,esi
       test      ebx,ebx
       jle       short M02_L18
M02_L17:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M02_L21
       mov       eax,esi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       esi,1
       jo        short M02_L20
       cmp       esi,ebx
       jl        short M02_L17
M02_L18:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       ebx,[rbp-48]
       xor       esi,esi
       jmp       short M02_L23
M02_L22:
       mov       rdi,[rbp+10]
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M02_L24
       mov       eax,esi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       esi,1
       jo        short M02_L25
M02_L23:
       cmp       esi,ebx
       jl        short M02_L22
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 804
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C94ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CEF0690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4C4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CEF0690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CEF0690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CEDE6D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       cmp       edi,esi
       jge       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
       cmp       edi,esi
       jl        short M01_L12
M01_L13:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L19
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,23DB6D87350
       mov       r8,r9
       call      qword ptr [7FFE5CEDE7C0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L02
M02_L01:
       mov       rdx,[rdi+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M02_L09
       mov       r8d,ecx
       add       eax,[rdx+r8*4+10]
       jo        near ptr M02_L12
       add       ecx,1
       jo        near ptr M02_L12
M02_L02:
       mov       rdi,[rbp+10]
       mov       rdx,[rdi+10]
       mov       rdx,[rdx+18]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       short M02_L03
       test      eax,eax
       jge       short M02_L01
M02_L03:
       mov       ecx,[rbx+8]
       sub       ecx,eax
       jo        near ptr M02_L12
       cmp       ecx,esi
       jl        near ptr M02_L10
       test      eax,eax
       jl        near ptr M02_L10
       xor       r8d,r8d
       mov       [rbp-50],r8
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovge    r8d,edx
       mov       eax,r8d
       test      r8d,r8d
       je        near ptr M02_L13
M02_L04:
       test      eax,eax
       je        near ptr M02_L14
M02_L05:
       mov       r8,[rdi+10]
       mov       r14,[r8+8]
       xor       r15d,r15d
       mov       r13d,[r14+8]
       mov       r12d,r13d
       test      r12,r12
       jle       near ptr M02_L16
M02_L06:
       cmp       r15d,r13d
       jae       short M02_L09
       mov       r8d,r15d
       mov       rax,[r14+r8*8+10]
       test      rax,rax
       je        short M02_L08
M02_L07:
       mov       [rbp-58],rax
       mov       r8,[rax+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        near ptr M02_L12
       mov       rcx,[rbp-58]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       rax,rcx
       jne       short M02_L07
M02_L08:
       add       r15d,1
       jo        short M02_L12
       movsxd    rcx,r15d
       cmp       r12,rcx
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L10:
       call      qword ptr [7FFE5C9D54D0]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L11
       call      qword ptr [7FFE5C9D51D0]
       mov       r14,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,335F
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5747B0]
       mov       esi,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFE5C9D52A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFE5C9D50C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23DB6D97598
       mov       r8,rbx
       call      qword ptr [7FFE5C57D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       esi,[rbp-48]
       xor       r14d,r14d
       test      esi,esi
       jle       short M02_L18
M02_L17:
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M02_L21
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       r14d,1
       jo        short M02_L20
       cmp       r14d,esi
       jl        short M02_L17
M02_L18:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       rcx,rdx
       mov       rdx,7FFE5CEF0ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       esi,[rbp-48]
       xor       r14d,r14d
       jmp       short M02_L23
M02_L22:
       mov       rdi,[rbp+10]
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M02_L24
       mov       eax,r14d
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       r14d,1
       jo        short M02_L25
M02_L23:
       cmp       r14d,esi
       jl        short M02_L22
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 812
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C95ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF00508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF00508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF00508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CEEED00]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L19
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,1C2B19C7350
       mov       r8,r9
       call      qword ptr [7FFE5CEEEDF0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L02
M02_L01:
       mov       r8,[rdx+10]
       mov       r8,[r8+10]
       cmp       ecx,[r8+8]
       jae       near ptr M02_L08
       mov       r10d,ecx
       add       eax,[r8+r10*4+10]
       jo        near ptr M02_L12
       add       ecx,1
       jo        near ptr M02_L12
M02_L02:
       mov       rdx,[rbp+10]
       mov       r8,[rdx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,ecx
       cmp       r8,r10
       jle       short M02_L03
       test      eax,eax
       jge       short M02_L01
M02_L03:
       mov       ecx,[rbx+8]
       sub       ecx,eax
       jo        near ptr M02_L12
       cmp       ecx,esi
       jl        near ptr M02_L10
       test      eax,eax
       jl        near ptr M02_L10
       xor       r8d,r8d
       mov       [rbp-50],r8
       xor       ecx,ecx
       cmp       esi,7FFFFFFF
       setle     cl
       test      esi,esi
       cmovge    r8d,ecx
       mov       eax,r8d
       test      r8d,r8d
       je        near ptr M02_L13
M02_L04:
       test      eax,eax
       je        near ptr M02_L14
M02_L05:
       mov       r8,[rdx+10]
       mov       rdi,[r8+8]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       mov       r13d,r15d
       test      r13,r13
       jle       near ptr M02_L16
M02_L06:
       cmp       r14d,r15d
       jae       short M02_L08
       mov       r8d,r14d
       mov       r12,[rdi+r8*8+10]
       test      r12,r12
       jne       short M02_L09
M02_L07:
       add       r14d,1
       jo        near ptr M02_L12
       movsxd    rcx,r14d
       cmp       r13,rcx
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L09:
       mov       r8,[r12+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        short M02_L12
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L09
       jmp       short M02_L07
M02_L10:
       call      qword ptr [7FFE5C9E54D0]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L11
       call      qword ptr [7FFE5C9E51D0]
       mov       rdi,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,335F
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5847B0]
       mov       esi,eax
       mov       rdx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFE5C9E52A8]
       mov       r12,rax
       test      r12,r12
       jne       short M02_L15
       call      qword ptr [7FFE5C9E50C8]
       mov       r12,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1C2B19D7598
       mov       r8,r12
       call      qword ptr [7FFE5C58D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       test      r12d,r12d
       jle       short M02_L18
M02_L17:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M02_L21
       mov       eax,ebx
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L20
       cmp       ebx,r12d
       jl        short M02_L17
M02_L18:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       rcx,rdx
       mov       rdx,7FFE5CF00D50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       jmp       short M02_L23
M02_L22:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M02_L24
       mov       eax,ebx
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L25
M02_L23:
       cmp       ebx,r12d
       jl        short M02_L22
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 810
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C97ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF20508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF20508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF20508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CF0ED00]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L19
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,220150E7350
       mov       r8,r9
       call      qword ptr [7FFE5CF0EDF0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       r8d,r8d
       xor       edx,edx
       jmp       short M02_L02
M02_L01:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M02_L08
       mov       r10d,edx
       add       r8d,[rax+r10*4+10]
       jo        near ptr M02_L12
       add       edx,1
       jo        near ptr M02_L12
M02_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r10,edx
       cmp       rax,r10
       jle       short M02_L03
       test      r8d,r8d
       jge       short M02_L01
M02_L03:
       mov       edx,[rbx+8]
       sub       edx,r8d
       jo        near ptr M02_L12
       cmp       edx,esi
       jl        short M02_L09
       test      r8d,r8d
       jl        short M02_L09
       xor       r8d,r8d
       mov       [rbp-50],r8
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovge    r8d,edx
       mov       eax,r8d
       test      r8d,r8d
       je        near ptr M02_L13
M02_L04:
       test      eax,eax
       je        near ptr M02_L14
M02_L05:
       mov       r8,[rcx+10]
       mov       rdi,[r8+8]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       mov       r13d,r15d
       test      r13,r13
       jle       near ptr M02_L16
M02_L06:
       cmp       r14d,r15d
       jae       short M02_L08
       mov       r8d,r14d
       mov       r12,[rdi+r8*8+10]
       test      r12,r12
       jne       short M02_L11
M02_L07:
       add       r14d,1
       jo        near ptr M02_L12
       movsxd    rax,r14d
       cmp       r13,rax
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L09:
       call      qword ptr [7FFE5CA054D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L10
       call      qword ptr [7FFE5CA051D0]
       mov       rbx,rax
M02_L10:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,335F
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFE5C4FF750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M02_L11:
       mov       r8,[r12+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        short M02_L12
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L11
       jmp       near ptr M02_L07
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     edx,byte ptr [rbp-50]
       test      dl,dl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5A47B0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFE5CA052A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFE5CA050C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,220150F7598
       mov       r8,rbx
       call      qword ptr [7FFE5C5AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       test      r12d,r12d
       jle       short M02_L18
M02_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       ebx,[rax+8]
       jae       short M02_L21
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L20
       cmp       ebx,r12d
       jl        short M02_L17
M02_L18:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       rcx,rdx
       mov       rdx,7FFE5CF20D50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       jmp       short M02_L23
M02_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       ebx,[rax+8]
       jae       short M02_L24
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L25
M02_L23:
       cmp       ebx,r12d
       jl        short M02_L22
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 807
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C94ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4C4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10690
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CF04BE8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L21
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,21A884A7350
       mov       r8,r9
       call      qword ptr [7FFE5CF04CD8]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       r8d,r8d
       xor       edx,edx
       jmp       short M02_L02
M02_L01:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M02_L09
       mov       r10d,edx
       add       r8d,[rax+r10*4+10]
       jo        near ptr M02_L13
       add       edx,1
       jo        near ptr M02_L13
M02_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r10,edx
       cmp       rax,r10
       jle       short M02_L03
       test      r8d,r8d
       jge       short M02_L01
M02_L03:
       mov       edx,[rbx+8]
       sub       edx,r8d
       jo        near ptr M02_L13
       cmp       edx,esi
       jl        short M02_L10
       test      r8d,r8d
       jl        short M02_L10
       xor       r8d,r8d
       mov       [rbp-50],r8
       test      esi,esi
       jl        near ptr M02_L14
       xor       edi,edi
       cmp       esi,7FFFFFFF
       setle     dil
M02_L04:
       mov       eax,edi
       test      edi,edi
       je        near ptr M02_L15
M02_L05:
       test      eax,eax
       je        near ptr M02_L16
M02_L06:
       mov       r8,[rcx+10]
       mov       rdi,[r8+8]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       mov       r13d,r15d
       test      r13,r13
       jle       near ptr M02_L18
M02_L07:
       cmp       r14d,r15d
       jae       short M02_L09
       mov       r8d,r14d
       mov       r12,[rdi+r8*8+10]
       test      r12,r12
       jne       short M02_L12
M02_L08:
       add       r14d,1
       jo        near ptr M02_L13
       movsxd    rax,r14d
       cmp       r13,rax
       jg        short M02_L07
       jmp       near ptr M02_L18
M02_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L10:
       call      qword ptr [7FFE5C9D54D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L11
       call      qword ptr [7FFE5C9D51D0]
       mov       rbx,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,335F
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFE5C4CF750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M02_L12:
       mov       r8,[r12+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        short M02_L13
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L12
       jmp       near ptr M02_L08
M02_L13:
       call      CORINFO_HELP_OVERFLOW
M02_L14:
       xor       edi,edi
       jmp       near ptr M02_L04
M02_L15:
       movzx     edx,byte ptr [rbp-50]
       test      dl,dl
       je        near ptr M02_L05
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5747B0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L06
M02_L16:
       call      qword ptr [7FFE5C9D52A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L17
       call      qword ptr [7FFE5C9D50C8]
       mov       rbx,rax
M02_L17:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21A884B7598
       mov       r8,rbx
       call      qword ptr [7FFE5C57D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       test      r12d,r12d
       jle       short M02_L20
M02_L19:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       ebx,[rax+8]
       jae       short M02_L23
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L22
       cmp       ebx,r12d
       jl        short M02_L19
M02_L20:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L21:
       mov       rcx,rdx
       mov       rdx,7FFE5CF10ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L22:
       call      CORINFO_HELP_OVERFLOW
M02_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       jmp       short M02_L25
M02_L24:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       ebx,[rax+8]
       jae       short M02_L26
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L27
M02_L25:
       cmp       ebx,r12d
       jl        short M02_L24
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 815
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C97ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CFF62E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,7FFE5D003D68
       call      qword ptr [7FFE5C4F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CFF62E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CFF62E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5D007E28]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L19
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,2368D167350
       mov       r8,r9
       call      qword ptr [7FFE5D007F18]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       r8d,r8d
       xor       edx,edx
       jmp       short M02_L02
M02_L01:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M02_L08
       mov       r10d,edx
       add       r8d,[rax+r10*4+10]
       jo        near ptr M02_L12
       add       edx,1
       jo        near ptr M02_L12
M02_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r10,edx
       cmp       rax,r10
       jle       short M02_L03
       test      r8d,r8d
       jge       short M02_L01
M02_L03:
       mov       edx,[rbx+8]
       sub       edx,r8d
       jo        near ptr M02_L12
       cmp       edx,esi
       jl        short M02_L09
       test      r8d,r8d
       jl        short M02_L09
       xor       r8d,r8d
       mov       [rbp-50],r8
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovge    r8d,edx
       mov       eax,r8d
       test      r8d,r8d
       je        near ptr M02_L13
M02_L04:
       test      eax,eax
       je        near ptr M02_L14
M02_L05:
       mov       r8,[rcx+10]
       mov       rdi,[r8+8]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       mov       r13d,r15d
       test      r13,r13
       jle       near ptr M02_L16
M02_L06:
       cmp       r14d,r15d
       jae       short M02_L08
       mov       r8d,r14d
       mov       r12,[rdi+r8*8+10]
       test      r12,r12
       jne       short M02_L11
M02_L07:
       add       r14d,1
       jo        near ptr M02_L12
       movsxd    rax,r14d
       cmp       r13,rax
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L09:
       call      qword ptr [7FFE5CA054D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L10
       call      qword ptr [7FFE5CA051D0]
       mov       rbx,rax
M02_L10:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,335F
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFE5C4FF750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M02_L11:
       mov       r8,[r12+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        short M02_L12
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L11
       jmp       near ptr M02_L07
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     edx,byte ptr [rbp-50]
       test      dl,dl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5A47B0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFE5CA052A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFE5CA050C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2368D177598
       mov       r8,rbx
       call      qword ptr [7FFE5C5AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       test      r12d,r12d
       jle       short M02_L18
M02_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       ebx,[rax+8]
       jae       short M02_L21
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L20
       cmp       ebx,r12d
       jl        short M02_L17
M02_L18:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       rcx,rdx
       mov       rdx,7FFE5CFF6B60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       r12d,[rbp-48]
       xor       ebx,ebx
       jmp       short M02_L23
M02_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       ebx,[rax+8]
       jae       short M02_L24
       mov       edx,ebx
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       ebx,1
       jo        short M02_L25
M02_L23:
       cmp       ebx,r12d
       jl        short M02_L22
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 807
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C96AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C96ADF8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5D09C820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,7FFE5D0BA610
       call      qword ptr [7FFE5C4E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5D09C820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5D09C820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5D0BE6D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       cmp       edi,esi
       jge       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
       cmp       edi,esi
       jl        short M01_L12
M01_L13:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       mov       [rbp-60],rsp
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        near ptr M02_L19
M02_L00:
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,24B41427350
       mov       r8,r9
       call      qword ptr [7FFE5D0BE7C0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       r8d,r8d
       xor       edx,edx
       jmp       short M02_L02
M02_L01:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M02_L09
       mov       r10d,edx
       add       r8d,[rax+r10*4+10]
       jo        near ptr M02_L10
       add       edx,1
       jo        near ptr M02_L10
M02_L02:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r10,edx
       cmp       rax,r10
       jle       short M02_L03
       test      r8d,r8d
       jge       short M02_L01
M02_L03:
       mov       edx,[rbx+8]
       sub       edx,r8d
       jo        near ptr M02_L10
       cmp       edx,esi
       jl        near ptr M02_L14
       test      r8d,r8d
       jl        near ptr M02_L14
       xor       r8d,r8d
       mov       [rbp-50],r8
       xor       edx,edx
       cmp       esi,7FFFFFFF
       setle     dl
       test      esi,esi
       cmovge    r8d,edx
       mov       eax,r8d
       test      r8d,r8d
       je        short M02_L11
M02_L04:
       test      eax,eax
       je        near ptr M02_L12
M02_L05:
       mov       r8,[rcx+10]
       mov       rdi,[r8+8]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       mov       r13d,r15d
       test      r13,r13
       jle       near ptr M02_L16
M02_L06:
       cmp       r14d,r15d
       jae       short M02_L09
       mov       r8d,r14d
       mov       r12,[rdi+r8*8+10]
       test      r12,r12
       je        short M02_L08
M02_L07:
       mov       r8,[r12+8]
       movsxd    rdx,esi
       mov       rcx,rbx
       call      CORINFO_HELP_ARRADDR_ST
       add       esi,1
       jo        short M02_L10
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L07
M02_L08:
       add       r14d,1
       jo        short M02_L10
       movsxd    rax,r14d
       cmp       r13,rax
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L10:
       call      CORINFO_HELP_OVERFLOW
M02_L11:
       movzx     edx,byte ptr [rbp-50]
       test      dl,dl
       je        short M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFE5C5947B0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L05
M02_L12:
       call      qword ptr [7FFE5C9F52A8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L13
       call      qword ptr [7FFE5C9F50C8]
       mov       rdi,rax
M02_L13:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,24B414375C0
       mov       r8,rdi
       call      qword ptr [7FFE5C59D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L14:
       call      qword ptr [7FFE5C9F54D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFE5C9F51D0]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,335F
       mov       rdx,7FFE5C7FB4E8
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C4EF750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       esi,[rbp-48]
       xor       edi,edi
       test      esi,esi
       jle       short M02_L18
M02_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M02_L21
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M02_L20
       cmp       edi,esi
       jl        short M02_L17
M02_L18:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L19:
       mov       rcx,rdx
       mov       rdx,7FFE5D09D098
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       jmp       near ptr M02_L00
M02_L20:
       call      CORINFO_HELP_OVERFLOW
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       esi,[rbp-48]
       xor       edi,edi
       jmp       short M02_L23
M02_L22:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M02_L24
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M02_L25
M02_L23:
       cmp       edi,esi
       jl        short M02_L22
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L24:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 793
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C96AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CEDE2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CEDE2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CEDE2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CEFD320]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       cmp       edi,esi
       jge       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
       cmp       edi,esi
       jl        short M01_L12
M01_L13:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 495
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF00630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF00630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF00630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CEEEFE8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF004A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4D4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF004A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF004A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CEEECE8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       cmp       edi,esi
       jge       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
       cmp       edi,esi
       jl        short M01_L12
M01_L13:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 495
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF204A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF204A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF204A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CF0EFE8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF204A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF204A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF204A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CF0ECE8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C96AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5CF35870
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+<>c[[System.__Canon, System.Private.CoreLib]].<get_Count>b__33_0(Int32, Int32)
       call      qword ptr [7FFE5C4E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5CF35870
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5CF35870
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5CF2DA40]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C97AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5D004040
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,7FFE5D013210
       call      qword ptr [7FFE5C4F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5D004040
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5D004040
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5D0172D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C96AE08]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rsp
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       lea       r9,[rbp-28]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFE5C94C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        near ptr M01_L05
       jmp       near ptr M01_L06
M01_L00:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rsi,[rax+40]
       test      rsi,rsi
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rcx,rdx
       mov       rdx,7FFE5D09CA50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rsi,rax
M01_L02:
       mov       rcx,offset MT_System.Func`3[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,rdi
       mov       r8,7FFE5D0BA520
       call      qword ptr [7FFE5C4E4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdx
       mov       rdx,7FFE5D09CA50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L04:
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rdi
       jmp       short M01_L07
M01_L05:
       mov       rcx,rdx
       mov       rdx,7FFE5D09CA50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       mov       rbx,[rdx+10]
       mov       rcx,rax
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       test      r8,r8
       je        near ptr M01_L00
M01_L07:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE5D0BE5E0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
       mov       ebx,eax
       mov       esi,[rbp-28]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L09
M01_L08:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L11
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L10
       cmp       edi,esi
       jl        short M01_L08
M01_L09:
       mov       eax,ebx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-28]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 493
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C93D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C93D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L03
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       jne       short M01_L04
       add       ebx,1
       jo        short M01_L02
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L03
       jmp       short M01_L00
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       mov       rcx,rsp
       call      M01_L10
       jmp       short M01_L08
M01_L04:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L06
M01_L05:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L09
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L07
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L05
M01_L06:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L10:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L13
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L14
       cmp       edi,esi
       jl        short M01_L11
M01_L12:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 336
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L04
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       je        short M01_L02
       jmp       short M01_L05
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       add       ebx,1
       jo        short M01_L03
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L04
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L09
M01_L05:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L07
M01_L06:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L10
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L08
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L06
M01_L07:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L11:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 336
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C92D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L04
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       je        short M01_L02
       jmp       short M01_L05
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       add       ebx,1
       jo        short M01_L03
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L04
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L09
M01_L05:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L07
M01_L06:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L10
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L08
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L06
M01_L07:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L11:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 336
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C95D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L03
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       jne       short M01_L04
       add       ebx,1
       jo        short M01_L02
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L03
       jmp       short M01_L00
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       mov       rcx,rsp
       call      M01_L10
       jmp       short M01_L08
M01_L04:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L06
M01_L05:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L09
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L07
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L05
M01_L06:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L10:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L13
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L14
M01_L12:
       cmp       edi,esi
       jl        short M01_L11
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L03
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       jne       short M01_L04
       add       ebx,1
       jo        short M01_L02
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L03
       jmp       short M01_L00
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       mov       rcx,rsp
       call      M01_L10
       jmp       short M01_L08
M01_L04:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L06
M01_L05:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L09
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L07
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L05
M01_L06:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L10:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L13
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L14
       cmp       edi,esi
       jl        short M01_L11
M01_L12:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 336
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L04
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       je        short M01_L02
       jmp       short M01_L05
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       add       ebx,1
       jo        short M01_L03
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L04
       jmp       short M01_L00
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       mov       rcx,rsp
       call      M01_L11
       jmp       short M01_L09
M01_L05:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L07
M01_L06:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L10
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L08
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L06
M01_L07:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L11:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L14
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L15
M01_L13:
       cmp       edi,esi
       jl        short M01_L12
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 336
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L03
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       jne       short M01_L04
       add       ebx,1
       jo        short M01_L02
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L03
       jmp       short M01_L00
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L03:
       mov       rcx,rsp
       call      M01_L10
       jmp       short M01_L08
M01_L04:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L06
M01_L05:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L09
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L07
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L05
M01_L06:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L10:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L13
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L14
       cmp       edi,esi
       jl        short M01_L11
M01_L12:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 336
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94D8C0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       [rbp+10],rcx
       lea       r9,[rbp-20]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFE5C94D728]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       ebx,ebx
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M01_L08
M01_L00:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       ebx,[rax+8]
       jae       short M01_L01
       mov       edx,ebx
       cmp       dword ptr [rax+rdx*4+10],0
       je        short M01_L03
       jmp       short M01_L04
M01_L01:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       add       ebx,1
       jo        short M01_L02
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ebx
       cmp       rax,rdx
       jle       short M01_L08
       jmp       short M01_L00
M01_L04:
       mov       esi,[rbp-20]
       xor       edi,edi
       test      esi,esi
       jle       short M01_L06
M01_L05:
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L09
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L07
       cmp       edi,esi
       mov       rcx,[rbp+10]
       jl        short M01_L05
M01_L06:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       rcx,rsp
       call      M01_L10
       nop
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L10:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       esi,[rbp-20]
       xor       edi,edi
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M01_L13
       mov       edx,edi
       mov       rcx,[rax+rdx*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M01_L14
M01_L12:
       cmp       edi,esi
       jl        short M01_L11
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 334
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C92D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5C9D52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE845D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4CE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CE84730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CE84748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9D52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6BEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,1DF03950008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C96D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5CA152C0]
       mov       ecx,333D
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA150B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEB6558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C50E040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CEB66B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CEB66C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5CA152C0]
       mov       ecx,333D
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA150B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6FEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,1C862000008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C94D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5C9F52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE96568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4EE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CE966C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CE966D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9F52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6DEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,14662A50008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C93D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5C9E52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-44],xmm4
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       mov       rbx,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L19
       mov       [rbp+18],rbx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-34],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-34]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L22
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-50],rdx
       xor       edx,edx
       mov       [rbp-40],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFE5CE86568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-40],0
       jne       short M01_L09
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-50]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L20
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L06
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       je        near ptr M01_L16
M01_L04:
       mov       r11d,[rbp-34]
       cmp       r11d,[r15+18]
       je        short M01_L08
M01_L05:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M01_L04
       jmp       near ptr M01_L16
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L10
       jmp       short M01_L11
M01_L09:
       call      qword ptr [7FFE5C4DE040]
       int       3
M01_L10:
       mov       rcx,rdx
       mov       rdx,7FFE5CE866C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L05
       test      r14,r14
       jne       short M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r8,[rax+38]
       test      r8,r8
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdx
       mov       rdx,7FFE5CE866D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L13:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L15
M01_L14:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L06
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L07
       mov       [rcx],eax
       mov       dword ptr [rbp-44],1
       jmp       near ptr M01_L21
M01_L16:
       cmp       byte ptr [rbp-40],0
       je        short M01_L17
       mov       rcx,[rbp-50]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L17:
       xor       eax,eax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       eax,[rbp-44]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       call      qword ptr [7FFE5C9E52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,rsp
       call      M01_L23
       jmp       near ptr M01_L01
M01_L21:
       mov       rcx,rsp
       call      M01_L23
       jmp       near ptr M01_L18
M01_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L23:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-40],0
       je        short M01_L24
       mov       rcx,[rbp-50]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 808
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6CEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2B79C1B0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C95D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5CA052C0]
       mov       ecx,333D
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA050B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEA64C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4FE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CEA6618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CEA6630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5CA052C0]
       mov       ecx,333D
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA050B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6EEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2939A9F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C94D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5C9F52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE9B820
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4EE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CE9B978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CE9B990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9F52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6DEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,1A2CA140008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C93D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5C9E52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CFA3EA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4DE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CFA3FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CFA4010
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9E52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6CEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,30D2A9E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],cl
       xor       eax,eax
       test      rdx,rdx
       setne     al
       test      eax,eax
       je        short M00_L00
       call      qword ptr [7FFE5C96D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE5CA152C0]
       mov       ecx,333D
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA150B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5D083728
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C50E040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5D083880
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5D083898
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5CA152C0]
       mov       ecx,333D
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA150B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE5C5B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE5C6FEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,1FAF6610008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEB45D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4FE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CEB4730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CEB4748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5CA052C0]
       mov       ecx,333D
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA050B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE764C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4CE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CE76618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CE76630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9D52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C94D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE96558
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4EE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CE966B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CE966C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9F52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7FB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9F50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-44],xmm4
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-60],rsp
       mov       [rbp-30],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       [rcx],ecx
       mov       rbx,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L19
       mov       [rbp+18],rbx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r11,[rax+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rbx
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-34],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-34]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L22
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-50],rdx
       xor       edx,edx
       mov       [rbp-40],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,7FFE5CE764C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-40],0
       jne       short M01_L09
       lea       rdx,[rbp-40]
       mov       rcx,[rbp-50]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L20
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L06
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       je        near ptr M01_L16
M01_L04:
       mov       r11d,[rbp-34]
       cmp       r11d,[r15+18]
       je        short M01_L08
M01_L05:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M01_L04
       jmp       near ptr M01_L16
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L10
       jmp       short M01_L11
M01_L09:
       call      qword ptr [7FFE5C4CE040]
       int       3
M01_L10:
       mov       rcx,rdx
       mov       rdx,7FFE5CE76618
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        short M01_L05
       test      r14,r14
       jne       short M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       r8,[rax+38]
       test      r8,r8
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rdx
       mov       rdx,7FFE5CE76630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L13:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L15
M01_L14:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L06
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L07
       mov       [rcx],eax
       mov       dword ptr [rbp-44],1
       jmp       near ptr M01_L21
M01_L16:
       cmp       byte ptr [rbp-40],0
       je        short M01_L17
       mov       rcx,[rbp-50]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L17:
       xor       eax,eax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       mov       eax,[rbp-44]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       call      qword ptr [7FFE5C9D52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,rsp
       call      M01_L23
       jmp       near ptr M01_L01
M01_L21:
       mov       rcx,rsp
       call      M01_L23
       jmp       near ptr M01_L18
M01_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L23:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-40],0
       je        short M01_L24
       mov       rcx,[rbp-50]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L24:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 808
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C93D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CE86568
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4DE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CE866C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CE866D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9E52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9E50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C95D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEAD388
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4FE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CEAD4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CEAD4F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5CA052C0]
       mov       ecx,333D
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5CA050B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5CEECD48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4CE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5CEECEA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5CEECEB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9D52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       rdx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C92D878]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].TryRemove(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-4C],xmm4
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-60],rsp
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rsi,[rbp+18]
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       setne     dl
       test      edx,edx
       je        near ptr M01_L18
       mov       [rbp+18],rsi
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+28]
       test      r11,r11
       je        short M01_L02
M01_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r8d,eax
       mov       [rbp-3C],r8d
M01_L01:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+10]
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-3C]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      r8d
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M01_L21
       mov       edx,edi
       mov       rdx,[r10+rdx*8+10]
       mov       [rbp-58],rdx
       xor       edx,edx
       mov       [rbp-48],edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rbx
       mov       rdx,7FFE5D0434F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M01_L00
M01_L03:
       cmp       byte ptr [rbp-48],0
       jne       short M01_L07
       lea       rdx,[rbp-48]
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbp+10]
       cmp       rbx,[rcx+10]
       jne       near ptr M01_L19
       xor       r14d,r14d
       mov       rax,[rbx+8]
       cmp       esi,[rax+8]
       jae       short M01_L04
       mov       edx,esi
       mov       r15,[rax+rdx*8+10]
       test      r15,r15
       jne       short M01_L06
       jmp       near ptr M01_L15
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       r11d,[rbp-3C]
       cmp       r11d,[r15+18]
       jne       near ptr M01_L14
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       r13,rdx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE5C4CE040]
       int       3
M01_L08:
       mov       rcx,rdx
       mov       rdx,7FFE5D043650
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
M01_L09:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[r15+8]
       mov       r11,rax
       mov       r8,[rbp+18]
       call      qword ptr [rax]
       test      eax,eax
       je        near ptr M01_L14
       test      r14,r14
       jne       short M01_L12
       mov       rcx,[r13+30]
       mov       rcx,[rcx]
       mov       r8,[rcx+38]
       test      r8,r8
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,r13
       mov       rdx,7FFE5D043668
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r8,rax
M01_L11:
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       call      CORINFO_HELP_LDELEMA_REF
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M01_L04
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        near ptr M01_L05
       mov       [rcx],eax
       mov       dword ptr [rbp-4C],1
       jmp       near ptr M01_L20
M01_L14:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       near ptr M01_L06
M01_L15:
       cmp       byte ptr [rbp-48],0
       je        short M01_L16
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L16:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       call      qword ptr [7FFE5C9D52C0]
       mov       ecx,333D
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7DB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE5C4C6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9D50B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C6E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L01
M01_L20:
       mov       rcx,rsp
       call      M01_L22
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       byte ptr [rbp-48],0
       je        short M01_L23
       mov       rcx,[rbp-58]
       call      System.Threading.Monitor.Exit(System.Object)
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 820
```

