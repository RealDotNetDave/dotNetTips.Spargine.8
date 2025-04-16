## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32765848
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
       mov       rdx,7FFD32765B10
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
       call      qword ptr [7FFD3273E2F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32757708
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
       mov       rdx,7FFD327579D0
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
       call      qword ptr [7FFD3273F930]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327676F0
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
       mov       rdx,7FFD327679B8
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
       call      qword ptr [7FFD3274F930]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32767708
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
       mov       rdx,7FFD327679D0
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
       call      qword ptr [7FFD3274F930]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327676F0
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
       mov       rdx,7FFD327679B8
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
       call      qword ptr [7FFD3274F930]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32767708
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
       mov       rdx,7FFD327679D0
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
       call      qword ptr [7FFD3274F930]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32825450
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
       mov       rdx,7FFD32825718
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
       call      qword ptr [7FFD328347E0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3223B8E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Clear()
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
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newTables = new Tables(new Node[DefaultCapacity], this._tables._locks, new int[this._tables._countPerLock.Length]);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._tables = newTables;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this._budget = Math.Max(1, newTables._buckets.Length / newTables._locks.Length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD329571D8
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
       mov       rdx,7FFD329574A0
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
       call      qword ptr [7FFD328FF798]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1+Tables[[System.__Canon, System.Private.CoreLib]]..ctor(Node<System.__Canon>[], System.Object[], Int32[])
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD327760A8
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
       mov       rdx,7FFD32776200
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD32767F50
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
       mov       rdx,7FFD327680A8
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD32747F50
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
       mov       rdx,7FFD327480A8
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD32757F50
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
       mov       rdx,7FFD327580A8
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD32747F50
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
       mov       rdx,7FFD327480A8
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3223B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD32777F60
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
       mov       rdx,7FFD327780B8
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD32828DF0
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
       mov       rdx,7FFD32828F48
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       mov       rdx,[rbx+50]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B8F0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].Contains(System.__Canon)
; 		var hashCode = this._comparer.GetHashCode(item);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var tables = this._tables;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bucketNo = GetBucket(hashCode, tables._buckets.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var current = Volatile.Read(ref tables._buckets[bucketNo]);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (hashCode == current._hashCode && this._comparer.Equals(current._item, item))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				return true;
; 				^^^^^^^^^^^^
; 			current = current._next;
; 			^^^^^^^^^^^^^^^^^^^^^^^^
; 		while (current is not null)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       mov       rdx,7FFD32937970
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
       mov       rdx,7FFD32937AC8
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3221B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327D0690
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
       call      qword ptr [7FFD31D94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327D0690
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
       mov       rdx,7FFD327D0690
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
       call      qword ptr [7FFD327BDA58]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,230AEBD7350
       mov       r8,r9
       call      qword ptr [7FFD327BDB48]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       call      qword ptr [7FFD3225FD68]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L11
       call      qword ptr [7FFD3225FA68]
       mov       r14,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320BB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFD31D9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFD31E447B0]
       mov       esi,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3225FB40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFD3225F960]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,230AEBE7600
       mov       r8,rbx
       call      qword ptr [7FFD31E4D470]
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
       mov       rdx,7FFD327D0ED8
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
; Total bytes of code 797
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3221B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327D1E38
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
       call      qword ptr [7FFD31D94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327D1E38
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
       mov       rdx,7FFD327D1E38
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
       call      qword ptr [7FFD327BE6D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,31367837350
       mov       r8,r9
       call      qword ptr [7FFD327BE7C0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       call      qword ptr [7FFD3225FD68]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L11
       call      qword ptr [7FFD3225FA68]
       mov       r14,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320BB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFD31D9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFD31E447B0]
       mov       esi,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3225FB40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFD3225F960]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,31367847620
       mov       r8,rbx
       call      qword ptr [7FFD31E4D470]
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
       mov       rdx,7FFD327D2680
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
; Total bytes of code 799
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3222B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327E1E38
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
       call      qword ptr [7FFD31DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327E1E38
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
       mov       rdx,7FFD327E1E38
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
       call      qword ptr [7FFD327CE6D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,2ADA9E67350
       mov       r8,r9
       call      qword ptr [7FFD327CE7C0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       call      qword ptr [7FFD3226FD68]
       mov       r14,rax
       test      r14,r14
       jne       short M02_L11
       call      qword ptr [7FFD3226FA68]
       mov       r14,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320CB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFD31DAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFD31E547B0]
       mov       esi,eax
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3226FB40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFD3226F960]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2ADA9E77620
       mov       r8,rbx
       call      qword ptr [7FFD31E5D470]
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
       mov       rdx,7FFD327E2680
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
; Total bytes of code 799
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3222B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327E1E38
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
       call      qword ptr [7FFD31DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327E1E38
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
       mov       rdx,7FFD327E1E38
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
       call      qword ptr [7FFD327CE6D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,24972B67350
       mov       r8,r9
       call      qword ptr [7FFD327CE7C0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       call      qword ptr [7FFD3226FD68]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L11
       call      qword ptr [7FFD3226FA68]
       mov       rdi,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320CB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD31DAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFD31E547B0]
       mov       esi,eax
       mov       rdx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3226FB40]
       mov       r12,rax
       test      r12,r12
       jne       short M02_L15
       call      qword ptr [7FFD3226F960]
       mov       r12,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,24972B77620
       mov       r8,r12
       call      qword ptr [7FFD31E5D470]
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
       mov       rdx,7FFD327E2680
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
; Total bytes of code 803
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3221B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327D1E38
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
       call      qword ptr [7FFD31D94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327D1E38
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
       mov       rdx,7FFD327D1E38
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
       call      qword ptr [7FFD327BE6D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,29DF5F17350
       mov       r8,r9
       call      qword ptr [7FFD327BE7C0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       xor       eax,eax
       xor       ecx,ecx
       jmp       short M02_L02
M02_L01:
       mov       r8,[rdx+10]
       mov       r8,[r8+10]
       cmp       ecx,[r8+8]
       jae       near ptr M02_L09
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       jo        short M02_L12
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L07
M02_L08:
       add       r14d,1
       jo        short M02_L12
       movsxd    rcx,r14d
       cmp       r13,rcx
       jg        short M02_L06
       jmp       near ptr M02_L16
M02_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M02_L10:
       call      qword ptr [7FFD3225FD68]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L11
       call      qword ptr [7FFD3225FA68]
       mov       rdi,rax
M02_L11:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320BB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD31D9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       call      CORINFO_HELP_OVERFLOW
M02_L13:
       movzx     ecx,byte ptr [rbp-50]
       test      cl,cl
       je        near ptr M02_L04
       lea       rcx,[rbp-50]
       call      qword ptr [7FFD31E447B0]
       mov       esi,eax
       mov       rdx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3225FB40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFD3225F960]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29DF5F27620
       mov       r8,rbx
       call      qword ptr [7FFD31E4D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       mov       esi,[rbp-48]
       xor       edi,edi
       test      esi,esi
       jle       short M02_L18
M02_L17:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L21
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
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
       mov       rdx,7FFD327D2680
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
       cmp       edi,esi
       jge       short M02_L23
M02_L22:
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M02_L24
       mov       eax,edi
       mov       rcx,[rcx+rax*8+10]
       call      System.Threading.Monitor.Exit(System.Object)
       add       edi,1
       jo        short M02_L25
       cmp       edi,esi
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
; Total bytes of code 794
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3222B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327E1E38
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
       call      qword ptr [7FFD31DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327E1E38
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
       mov       rdx,7FFD327E1E38
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
       call      qword ptr [7FFD327CE6D0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,1BF71527350
       mov       r8,r9
       call      qword ptr [7FFD327CE7C0]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       call      qword ptr [7FFD3226FD68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L10
       call      qword ptr [7FFD3226FA68]
       mov       rbx,rax
M02_L10:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320CB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFD31DAF750]
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
       call      qword ptr [7FFD31E547B0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3226FB40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFD3226F960]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1BF71537620
       mov       r8,rbx
       call      qword ptr [7FFD31E5D470]
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
       mov       rdx,7FFD327E2680
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
; Total bytes of code 800
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3220B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32906518
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
       mov       r8,7FFD328EBB28
       call      qword ptr [7FFD31D84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD32906518
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
       mov       rdx,7FFD32906518
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
       call      qword ptr [7FFD328EFBE8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,1F692B47350
       mov       r8,r9
       call      qword ptr [7FFD328EFCD8]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       call      qword ptr [7FFD3224FD68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L10
       call      qword ptr [7FFD3224FA68]
       mov       rbx,rax
M02_L10:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320AB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFD31D8F750]
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
       call      qword ptr [7FFD31E347B0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3224FB40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFD3224F960]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F692B57648
       mov       r8,rbx
       call      qword ptr [7FFD31E3D470]
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
       mov       rdx,7FFD32906D90
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
; Total bytes of code 800
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+280]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       movsxd    rdx,eax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD3221B8F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].CopyTo(System.__Canon[], Int32)
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
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32991120
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
       mov       r8,7FFD3298A028
       call      qword ptr [7FFD31D94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD32991120
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
       mov       rdx,7FFD32991120
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
       call      qword ptr [7FFD3298E0E8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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
; 		array = array.ArgumentItemsExists(nameof(array));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var locksAcquired = 0;
; 		^^^^^^^^^^^^^^^^^^^^^^
; 			this.AcquireAllLocks(ref locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			for (var lockCount = 0; lockCount < this._tables._locks.LongLength && count >= 0; lockCount++)
; 			     ^^^^^^^^^^^^^^^^^
; 				count += this._tables._countPerLock[lockCount];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (array.Length - count < arrayIndex || count < 0)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowArgumentInvalidException(Resources.TheIndexIsEqualToOrGreaterThanTheLengthOfInput, nameof(array));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.CopyToItems(array, arrayIndex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.ReleaseLocks(0, locksAcquired);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       r9,24250457350
       mov       r8,r9
       call      qword ptr [7FFD3298E1D8]; DotNetTips.Spargine.Core.Validator.ArgumentItemsExists[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.String, System.String)
       mov       rbx,rax
       lea       r9,[rbp-48]
       mov       rcx,[rbp+10]
       xor       edx,edx
       mov       r8d,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-48]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       r8d,esi
       not       r8d
       shr       r8d,1F
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
       call      qword ptr [7FFD3225FD68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L10
       call      qword ptr [7FFD3225FA68]
       mov       rbx,rax
M02_L10:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,3D2F
       mov       rdx,7FFD320BB908
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFD31D9F750]
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
       call      qword ptr [7FFD31E447B0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L05
M02_L14:
       call      qword ptr [7FFD3225FB40]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFD3225F960]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24250467648
       mov       r8,rbx
       call      qword ptr [7FFD31E4D470]
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
       mov       rdx,7FFD32991988
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
; Total bytes of code 800
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3221C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327E0630
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
       call      qword ptr [7FFD31DA4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327E0630
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
       mov       rdx,7FFD327E0630
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
       call      qword ptr [7FFD327CDA40]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327C1CD8
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
       call      qword ptr [7FFD31D84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327C1CD8
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
       mov       rdx,7FFD327C1CD8
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
       call      qword ptr [7FFD327AE5E0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327C1DD8
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
       call      qword ptr [7FFD31D84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327C1DD8
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
       mov       rdx,7FFD327C1DD8
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
       call      qword ptr [7FFD327AE6B8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327C1DD8
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
       call      qword ptr [7FFD31D84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327C1DD8
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
       mov       rdx,7FFD327C1DD8
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
       call      qword ptr [7FFD327AE6B8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3223B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327F1DD8
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
       call      qword ptr [7FFD31DB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327F1DD8
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
       mov       rdx,7FFD327F1DD8
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
       call      qword ptr [7FFD327DE6B8]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD327C1CD8
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
       call      qword ptr [7FFD31D84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD327C1CD8
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
       mov       rdx,7FFD327C1CD8
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
       call      qword ptr [7FFD327AE5E0]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3221B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32911BD8
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
       mov       r8,7FFD328FA5C8
       call      qword ptr [7FFD31D94210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD32911BD8
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
       mov       rdx,7FFD32911BD8
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
       call      qword ptr [7FFD328FE688]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220B908]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_Count()
; 			var count = 0;
; 			^^^^^^^^^^^^^^
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				count = this._tables._countPerLock.Aggregate(count, func: (accumulator, countPerLock) => accumulator += countPerLock);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return count;
; 			^^^^^^^^^^^^^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-28]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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
       mov       rdx,7FFD32980D80
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
       mov       r8,7FFD32969E90
       call      qword ptr [7FFD31D84210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
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
       mov       rdx,7FFD32980D80
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
       mov       rdx,7FFD32980D80
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
       call      qword ptr [7FFD3296DF50]; System.Linq.Enumerable.Aggregate[[System.Int32, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Int32>, Int32, System.Func`3<Int32,Int32,Int32>)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222C780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222C780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220C780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD321FC780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD321FC780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3220C780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD3220C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD321FC780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD321FC5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+280]
       cmp       [rcx],ecx
       call      qword ptr [7FFD3222C780]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].get_IsEmpty()
; 			var acquiredLocks = 0;
; 			^^^^^^^^^^^^^^^^^^^^^^
; 				this.AcquireAllLocks(ref acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				for (var counter = 0; counter < this._tables._countPerLock.LongLength; counter++)
; 				     ^^^^^^^^^^^^^^^
; 					if (this._tables._countPerLock[counter] != 0)
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 						return false;
; 						^^^^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		}
; 		^
; 				this.ReleaseLocks(0, acquiredLocks);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
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
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
       mov       rcx,[rbp+10]
       mov       r8,[rcx+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       lea       r9,[rbp-20]
       mov       edx,1
       call      qword ptr [7FFD3222C5E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet`1[[System.__Canon, System.Private.CoreLib]].AcquireLocks(Int32, Int32, Int32 ByRef)
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

