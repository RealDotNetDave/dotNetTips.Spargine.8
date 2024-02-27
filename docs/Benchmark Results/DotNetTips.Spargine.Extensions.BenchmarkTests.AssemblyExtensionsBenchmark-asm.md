## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllInterfaces01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FF814C7C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FF81524F378]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.Type>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81524F3D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FF814C7C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F52150],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rdx,28AEAFFB670
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Reflection.Assembly, System.Private.CoreLib]](System.Reflection.Assembly, System.Reflection.Assembly, System.String, System.String)
       xor       r8d,r8d
       mov       r9,28AEAFF0008
       call      qword ptr [7FF814FD7C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF814B7DF98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M02_L03
M02_L01:
       mov       rcx,[rbp-10]
       mov       eax,[rbp-14]
       cmp       eax,[rcx+8]
       jb        short M02_L02
       call      CORINFO_HELP_RNGCHKFAIL
M02_L02:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       nop
       mov       rcx,[rbp-8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+38]
       mov       [rbp-50],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B7E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       nop
       mov       ecx,[rbp-14]
       inc       ecx
       mov       [rbp-14],ecx
M02_L03:
       mov       ecx,[rbp-14]
       mov       rax,[rbp-10]
       cmp       ecx,[rax+8]
       jl        short M02_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B7E178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-58],rax
       mov       rax,[rbp-58]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 347
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814E1F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF81528CCA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815297D98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetAllTypes01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FF814C9C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      qword ptr [7FF815285F98]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Type, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.Type>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815285FE0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 50
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FF814C9C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814F72150],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       rdx,288E11CB670
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Reflection.Assembly, System.Private.CoreLib]](System.Reflection.Assembly, System.Reflection.Assembly, System.String, System.String)
       xor       r8d,r8d
       mov       r9,288E11C0008
       call      qword ptr [7FF814FF7C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp-18],rax
       mov       rcx,7FF814F72638
       mov       edx,33
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24857409B60
       mov       rcx,[rcx]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-20],0
       jne       near ptr M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,7FF814F72638
       mov       edx,33
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,24857409B58
       mov       rdx,[rdx]
       mov       [rbp-58],rdx
       mov       rdx,[rbp-58]
       mov       rcx,[rbp-50]
       mov       r8,7FF815282058
       call      qword ptr [7FF814AE4210]
       mov       rcx,7FF814F72638
       mov       edx,33
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-50]
       mov       rcx,24857409B60
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-50]
       mov       [rbp-30],r8
M02_L01:
       mov       r8,[rbp-30]
       mov       rdx,[rbp-28]
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>, System.Func`2<System.Type,Boolean>)
       call      qword ptr [7FF814F16928]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-38],rax
       mov       rdx,[rbp-38]
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.Type, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Type>)
       call      qword ptr [7FF8151E4150]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF814B9E178]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AsReadOnly()
       mov       [rbp-48],rax
       mov       rax,[rbp-48]
       mov       [rbp-8],rax
       nop
       mov       rax,[rbp-8]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 433
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF81529CE10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81528ED18]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark.GetInstances01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FF814C8C078]; System.Reflection.Assembly.GetExecutingAssembly()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]](System.Reflection.Assembly)
       call      qword ptr [7FF815275F38]; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark, DotNetTips.Spargine.Extensions.BenchmarkTests]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Extensions.BenchmarkTests.AssemblyExtensionsBenchmark>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815275F68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 60
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      qword ptr [7FF814C8C060]; System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 29
```
```assembly
; DotNetTips.Spargine.Extensions.AssemblyExtensions.GetInstances[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF814F62150],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF81523DFE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       mov       rcx,[rbp-20]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,0FFFFFFFE
       call      qword ptr [7FF815276070]; DotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-18]
       lea       rcx,[rcx+18]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-18]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FF81523E1A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815276220]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

